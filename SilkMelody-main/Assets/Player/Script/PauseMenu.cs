using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;
    private Player player;
    private InputMaster inputMaster;
    private InputAction pauseMenuAction;
    private bool isPaused;

    private void OnEnable()
    {
        inputMaster = new InputMaster();
        inputMaster.Enable();
        SetupInputActions();
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        if (inputMaster != null)
            inputMaster.Disable();
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void Start()
    {
        player = GameObject.Find("Tenroh")?.GetComponent<Player>();
        Time.timeScale = 1f;
        SetupInputActions();
    }

    private void SetupInputActions()
    {
        pauseMenuAction = inputMaster.Gameplay.Pause;
    }

    private void Update()
    {
        if (pauseMenuAction.WasPressedThisFrame())
        {
            if (isPaused)
                ContinueGame();
            else
                OpenSetting();
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        player = GameObject.Find("Tenroh")?.GetComponent<Player>();
    }

    public void OpenSetting()
    {
        if (isPaused) return;
        isPaused = true;
        if (player != null)
            player.disableControlCounter += 1;
        Time.timeScale = 0.5f;
        if (pauseMenuUI != null)
            pauseMenuUI.SetActive(true);
    }

    public void ContinueGame()
    {
        if (!isPaused) return;
        isPaused = false;
        if (player != null && player.disableControlCounter > 0)
            player.disableControlCounter -= 1;
        Time.timeScale = 1f;
        if (pauseMenuUI != null)
            pauseMenuUI.SetActive(false);
    }

    public void ExitToMainMenu()
    {
        Time.timeScale = 1f;
        if (player != null && player.disableControlCounter > 0)
            player.disableControlCounter -= 1;
        SceneManager.LoadScene("MainMenu");
    }
}
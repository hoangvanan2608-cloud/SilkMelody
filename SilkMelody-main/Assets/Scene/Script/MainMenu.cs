using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour, ISelectHandler, IDeselectHandler
{
    public AudioSource selectSound;

    private void Start()
    {
        if (transform.name == "Continue")
        {
            TextMeshProUGUI continueText = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
            if (!SaveSystem.CheckSaveExist())
            {
                Color noSaveColor = continueText.color;
                noSaveColor.a = 0.2f;
                continueText.color = noSaveColor;
            }
            else
            {
                EventSystem.current.firstSelectedGameObject = this.gameObject;
            }
        }
    }

    public void NewGameButton()
    {
        if (selectSound != null)
            selectSound.Play();
        SceneManager.LoadScene("DirtCave0");
    }

    public void ContinueButton()
    {
        if (SaveSystem.CheckSaveExist())
        {
            if (selectSound != null)
                selectSound.Play();
            SaveSystem.LoadPlayerData();
            SceneManager.LoadScene(GameMaster.instance.playerData.respawnScene);
        }
    }

    public void QuitButton()
    {
        if (selectSound != null)
            selectSound.Play();
        Debug.Log("Quit");
        Application.Quit();
    }

    private IEnumerator PlaySoundThenLoadScene(string sceneName)
    {
        if (selectSound != null)
        {
            selectSound.Play();
            yield return new WaitForSeconds(0.15f);
        }
        SceneManager.LoadScene(sceneName);
    }

    private IEnumerator PlaySoundThenQuit()
    {
        if (selectSound != null)
        {
            selectSound.Play();
            yield return new WaitForSeconds(0.15f);
        }
        Debug.Log("Quit");
        Application.Quit();
    }

    public void OnSelect(BaseEventData eventData)
    {
        if (selectSound != null)
            selectSound.Play();
    }

    public void OnDeselect(BaseEventData eventData) { }
}
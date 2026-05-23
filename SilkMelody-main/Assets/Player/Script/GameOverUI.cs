using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : MonoBehaviour
{
    public void Retry()
    {
        Time.timeScale = 1f;

        
        PlayerData data = GameMaster.instance.playerData;

        data.currentHp = data.maxHp;
        data.lifebloodHp = 0;
        data.currentSilk = 0;
        data.copperShard = 0;

        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;

        PlayerData data = GameMaster.instance.playerData;

        data.currentHp = data.maxHp;
        data.currentSilk = data.maxSilk;
        data.lifebloodHp = 0;

        SceneManager.LoadScene(0);
    }
}
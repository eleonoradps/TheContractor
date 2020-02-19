using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadPlayScene()
    {
        SceneManager.LoadScene("SceneLorna");
        Time.timeScale = 1f;
    }

    public void Quit()
    {
        Application.Quit();
    }
}

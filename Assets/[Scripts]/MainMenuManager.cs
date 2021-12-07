using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void Load_Scene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }


    public void ExitGame()
    {
        Application.Quit();
    }
     
    public void BackToMain()
    {
        SceneManager.LoadScene(0);
    }

    public void First()
    {
        SceneManager.LoadScene(3);
    }
    public void InstructionScreen()
    {
        SceneManager.LoadScene(2);
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
}

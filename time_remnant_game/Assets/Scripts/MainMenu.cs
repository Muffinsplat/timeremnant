using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

	public void PlayGame()
	{
		SceneManager.LoadScene(1);
	}

    public void Settings()
    {
        SceneManager.LoadScene(2);
    }

    public void Graphics()
    {
        SceneManager.LoadScene(3);
    }

    public void Keybindings()
    {
        SceneManager.LoadScene(4);
    }

    public void Sound()
    {
        SceneManager.LoadScene(5);
    }

    public void SettingsBack()
    {
        SceneManager.LoadScene(0);
    }

	public void QuitGame()
	{
		Application.Quit();
	}

}
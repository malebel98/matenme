using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pauseBtn, pauseMenu, slider;

    public void OnPause()
    {
        pauseMenu.SetActive(true);
        slider.SetActive(false);
        pauseBtn.SetActive(false);
        Time.timeScale = 0;
    }

    public void OffPause()
    {
        pauseMenu.SetActive(false);
        slider.SetActive(true);
        pauseBtn.SetActive(true);
        Time.timeScale = 1;
    }

    public void MainMenu(string backtomenu)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(backtomenu);
    }

    public void ExitGamebtn()
    {
        Application.Quit();
    }
}

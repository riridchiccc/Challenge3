using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] GameObject pauseMenuPanel;

    [SerializeField]PlayerControllerX controller;

    private void Update()
    {
        if (controller.gameOver)
            gameOverPanel.SetActive(true);
        else
            return;
    }

    public void onPressPauseButton()
    {
        Time.timeScale = 0f;
        pauseMenuPanel.SetActive(true);
    }

    public void onPressPlayButton()
    {
        Time.timeScale = 1f;
        pauseMenuPanel.SetActive(false);
    }

    public void onPressRetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        pauseMenuPanel.SetActive(false);
        
    }
    public void onPressMenuButton()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1f;
    }
    public void onPressQuitButton()
    {
        Application.Quit();
        Debug.Log("You quit the application");
    }
}

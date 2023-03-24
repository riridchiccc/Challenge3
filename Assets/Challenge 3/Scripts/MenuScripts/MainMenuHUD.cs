using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHUD : MonoBehaviour
{
    public GameObject OptionsMenu;

    public void onPressPlayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void onPressQuitButton()
    {
        Application.Quit();
        Debug.Log("You quit the application");
    }
    public void onPressOptionsButton()
    {
        OptionsMenu.SetActive(true);
       
    }
}

//code for managing pause menu///
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityStandardAssets.Characters.FirstPerson;

public class PauseGame : MonoBehaviour
{
    private GameObject pausemenuUI;
   // private  Button shootButton;
    private bool GameIsPaused;
    public void updateit()
    {
        clicked();
    }
    void clicked() { 
        if (GameIsPaused)
        {
            resume();
        }
        else
        {
            pause();
        }
    }



    // Update is called once per frame
    void pause()
    {
        pausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

    }
    public void resume()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject PauseUI;
    private bool paused = false;

    private void Start()
    {
        PauseUI.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            if(!paused)
                paused = !paused;
        }
        if (paused)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0f;
        }
        if (!paused)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1f;
   
        }
    }

    public void Resume()
    {
        paused = false;
    }

    public void Restart()
    {
        //Application.LoadLevel(Application.loadedLevel);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
    
}

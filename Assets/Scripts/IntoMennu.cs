using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntoMennu : MonoBehaviour {

    public GameObject Menu;

    private void Start()
    {
        
    }
    private void Update()
    {
        
    }

    public void play()
    {
        SceneManager.LoadScene(1);
    }

    public void load1()
    {
        SceneManager.LoadScene(3);
    }

    public void load2()
    {
        SceneManager.LoadScene(4);
    }

    public void load3()
    {
        SceneManager.LoadScene(5);
    }

    public void load4()
    {
        SceneManager.LoadScene(6);
    }

    public void load5()
    {
        SceneManager.LoadScene(7);
    }

    public void introduce()
    {
        SceneManager.LoadScene(2);
    }
    public void exit()
    {
        Application.Quit();
    }
}

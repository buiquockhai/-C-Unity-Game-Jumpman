using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LostMenu : MonoBehaviour {

    public GameObject LostUI;
    public GameObject Fallings;
    public GameObject Player;
    public GameObject ShowPoint;
    private bool lost = false;
    public Text point;

	void Start () {
        LostUI.SetActive(false);
	}
	
	void Update () {
        if (lost)
        {
            point.text = "Point: " + ShowPoint.GetComponent<GameController>().point.ToString();
            LostUI.SetActive(true);
            Fallings.SetActive(false);
            Player.SetActive(true);
        }
        if (!lost)
        {
            LostUI.SetActive(false);
        }
	}

    public void resetEndGame()
    {
        lost = true;
    }
    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void mainMenuGame()
    {
        SceneManager.LoadScene(0);
    }
}

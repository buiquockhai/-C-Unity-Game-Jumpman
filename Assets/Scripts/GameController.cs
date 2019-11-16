using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public GameObject resetScene;
    public int point;
    public int heart;
    public Text textPoint;
    public Text textHeart;

	void Start () {
        point = 0;
        heart = 1;
	}
	
	void Update () {
        //
        // Update point to display
        //
        textPoint.text = (point.ToString());
        // Update heart to display
        textHeart.text = (heart.ToString());
	}

    public void Point()
    {
        //
        // Increase point
        //
        point++;
    }

    public void plusHeart()
    {
        //
        // Increase heart
        //
        heart++;
    }

    public void subHeart()
    {
        heart--;
    }

    public void EndGame()
    {
        //
        //SceneManager.LoadScene(0);
        //
        resetScene.GetComponent<LostMenu>().resetEndGame();
    }
}

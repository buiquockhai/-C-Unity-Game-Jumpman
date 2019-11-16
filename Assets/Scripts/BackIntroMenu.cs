using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackIntroMenu : MonoBehaviour {

    public GameObject Panel;

	void Start () {
		
	}
	
	void Update () {
		
	}

    public void button()
    {
        SceneManager.LoadScene(0);
    }
}

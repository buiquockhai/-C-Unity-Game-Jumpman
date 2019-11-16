using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingMove : MonoBehaviour {

    //private bool check = false;
    public float moveSpeed = 2;
    public float minX, maxX;
    public float oldPosition;
    private GameObject obj;
    public GameObject coin1, coin2, coin3, coin4, bom, heart, wolf;

	void Start () {
        obj = gameObject;
        oldPosition = -10;
        maxX = 9;
        minX = -9;
	}
	
	// Update is called once per frame
	void Update () {
        obj.transform.Translate(new Vector3(0, Time.deltaTime * moveSpeed, 0));
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //coin.SetActive(true);
        if (collision.gameObject.tag.Equals("Reset"))
        {
            obj.transform.position = new Vector3(Random.Range(minX, maxX + 1), oldPosition, 0);
        }
        if (collision.gameObject.tag.Equals("EndTask"))
        {
            if (Random.Range(0, 101) > 80){
                if (Random.Range(0, 101) > 90)
                {
                    wolf.gameObject.SetActive(Random.Range(0, 101) > 90);
                    bom.gameObject.SetActive(true);
                    heart.gameObject.SetActive(true);
                    coin1.gameObject.SetActive(false);
                    coin2.gameObject.SetActive(false);
                    coin3.gameObject.SetActive(Random.Range(0, 101) > 65);
                    coin4.gameObject.SetActive(false);
                }
                else
                {
                    wolf.gameObject.SetActive(Random.Range(0, 101) > 91);
                    bom.gameObject.SetActive(true);
                    heart.gameObject.SetActive(false);
                    coin1.gameObject.SetActive(false);
                    coin2.gameObject.SetActive(Random.Range(0, 101) > 65);
                    coin3.gameObject.SetActive(Random.Range(0, 101) > 65);
                    coin4.gameObject.SetActive(false);
                }
            }
            else
            {
                if (Random.Range(0, 101) > 90)
                {
                    wolf.gameObject.SetActive(Random.Range(0, 101) > 85);
                    bom.gameObject.SetActive(false);
                    heart.gameObject.SetActive(true);
                    coin1.gameObject.SetActive(Random.Range(0, 101) > 65);
                    coin2.gameObject.SetActive(false);
                    coin3.gameObject.SetActive(Random.Range(0, 101) > 65);
                    coin4.gameObject.SetActive(Random.Range(0, 101) > 65);
                }
                else
                {
                    wolf.gameObject.SetActive(Random.Range(0, 101) > 85);
                    bom.gameObject.SetActive(false);
                    heart.gameObject.SetActive(false);
                    coin1.gameObject.SetActive(Random.Range(0, 101) > 65);
                    coin2.gameObject.SetActive(Random.Range(0, 101) > 65);
                    coin3.gameObject.SetActive(Random.Range(0, 101) > 65);
                    coin4.gameObject.SetActive(Random.Range(0, 101) > 65);
                }
            }
            
        }
            
    }
}

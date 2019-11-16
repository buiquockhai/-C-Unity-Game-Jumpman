using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour {

    public bool grounded;
    public float speed = 10f;
    public float jumpPower = 80f;
    private Rigidbody2D rb2d;
    private Animator amin;
    public GameObject gameController;
    //GameObject obj;
    public AudioClip coin;
    public AudioClip bomd;
    private AudioSource audioSource;

	void Start () {
        audioSource = gameObject.GetComponent<AudioSource>();
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        amin = gameObject.GetComponent<Animator>();
	}
	void Update () {
        //
        // Move left right
        //
        amin.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));
        amin.SetBool("Grounded", true);

        if (Input.GetAxis("Horizontal") < -0.1f) transform.localScale = new Vector3(-1, 1, 1);
        if (Input.GetAxis("Horizontal") > 0.1f) transform.localScale = new Vector3(1, 1, 1);

        var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += move * speed * Time.deltaTime;

        //
        // Jumping 
        //
        if (Input.GetButtonDown("Jump"))
        {
            // Animation_Air running
            amin.SetBool("Grounded", false);
            rb2d.AddForce(Vector2.up * jumpPower);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Die
        if (collision.CompareTag("EndTask"))
        {
            gameController.GetComponent<GameController>().EndGame();
        }
        // Die or decrease heart
        if (collision.CompareTag("Bom") || collision.CompareTag("Wolf"))
        {
            audioSource.clip = bomd;
            audioSource.Play();
            collision.gameObject.SetActive(false);
            gameController.GetComponent<GameController>().subHeart();
            if (gameController.GetComponent<GameController>().heart < 1)
                gameController.GetComponent<GameController>().EndGame();
        }

        // Increase heart
        if (collision.CompareTag("Heart"))
        {
            audioSource.clip = coin;
            audioSource.Play();
            collision.gameObject.SetActive(false);
            gameController.GetComponent<GameController>().plusHeart();
        }
            
        // Increase point
        if (collision.CompareTag("Coin"))
        {
            audioSource.clip = coin;
            audioSource.Play();
            collision.gameObject.SetActive(false);
            gameController.GetComponent<GameController>().Point();
        }
    }

    void EndGame()
    {
        
    }

    void FixedUpdate()
    {
        /*float h = Input.GetAxis("Horizontal");
        rb2d.AddForce(Vector2.right * speed * h);

        if (rb2d.velocity.x > maxSpeed) rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
        if (rb2d.velocity.x < -maxSpeed) rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
        */
    }
}

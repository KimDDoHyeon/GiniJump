using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player_1 : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float moveInput;
    private float speed = 3f;
    float horizontal;
    public Text scoreText;
    public float topScore = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb2d.velocity.y > 0 && transform.position.y > topScore)
        {
            topScore = transform.position.y;
        }
        scoreText.text = "Score: " + Mathf.Round(topScore).ToString();
    }
    void FixedUpdate()
    {
        /* if (Application.platform == RuntimePlatform.Android)
         {
             horizontal = Input.acceleration.x;
         }
         if (Input.acceleration.x < 0)
         {
             gameObject.GetComponent<SpriteRenderer>().flipX = false;
         }
         if (Input.acceleration.x > 0)
         {
             gameObject.GetComponent<SpriteRenderer>().flipX = true;
         }*/
        moveInput = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);

      //  rb2d.velocity = new Vector2(Input.acceleration.x * 20f, rb2d.velocity.y);
    }
}

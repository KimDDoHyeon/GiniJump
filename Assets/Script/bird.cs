using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bird : MonoBehaviour
{
    bool is_right = true;
    public float targetSpeed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            SceneManager.LoadScene("Start");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        targetSpeed = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (is_right) transform.Translate(Vector2.right * targetSpeed * Time.deltaTime);
        else transform.Translate(Vector2.left * targetSpeed * Time.deltaTime);

        if (transform.position.x > 2.5f) is_right = false;
        if (transform.position.x < -2.2f) is_right = true;
    }
}

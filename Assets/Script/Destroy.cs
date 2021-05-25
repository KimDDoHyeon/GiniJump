using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    public GameObject springPrefab;
    public GameObject catPrefab;
    public GameObject myPlat;
    public GameObject birdPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

      
        myPlat = (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-2.5f, 2.2f), player.transform.position.y + (14 + Random.Range(0.1f, 1f))), Quaternion.identity);
       


    }
}

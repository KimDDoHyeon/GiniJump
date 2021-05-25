using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (CompareTag("GameStart")) SceneManager.LoadScene("Start"); 
        if (CompareTag("Ranking")) SceneManager.LoadScene("Ranking");
        if (CompareTag("Option")) SceneManager.LoadScene("Option");
        if (CompareTag("Quit")) Application.Quit();
    }
}

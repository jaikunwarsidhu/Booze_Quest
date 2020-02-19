using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("");
        if(col.gameObject.tag == "Player")
        {
            //Application.Quit();
            SceneManager.LoadScene("EndScene");
        }
    }
}

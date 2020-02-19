using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, StartPosition;
    public GameObject CamerA;
    public float ParallaxEffect;


    
    void Start()
    {
        StartPosition = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    
    void FixedUpdate()
    {
        float move = (CamerA.transform.position.x * (1 - ParallaxEffect));
        float distance = (CamerA.transform.position.x * ParallaxEffect);

        transform.position = new Vector3(StartPosition + distance, transform.position.y, transform.position.z);
        //Debug.Log(ParallaxEffect);
        if(move > StartPosition + length)
        {
            StartPosition += length;
        }
        else if(move < StartPosition - length)
        {
            StartPosition -= length;
        }
    }
}

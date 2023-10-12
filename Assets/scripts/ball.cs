using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class ball : MonoBehaviour
{
    private score score;
    public float xposition = 1f;
    public float yposition = 1f;
    public float xspeed = 1f;
    public float yspeed = 1f;
    
    


    // Start is called before the first frame update
    void Start()
    {


        score = GameObject.FindObjectOfType<score>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        xposition += + xspeed * Time.deltaTime;
        yposition += + yspeed * Time.deltaTime;
        transform.position = new Vector3(xposition, yposition, 0);

        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("wall ver"))
        {
            xspeed = xspeed * -1f;
            Debug.Log("Colliders entering Collision up");
        }
        if (collision.gameObject.CompareTag("wall hor"))
        {
            yspeed = yspeed * -1f;
            Debug.Log("Colliders entering Collision down");
        }
        if (collision.gameObject.CompareTag("death R")) 
        {xposition = 0f; yposition = 0f;
            score.pointL();

        }
        if (collision.gameObject.CompareTag("death"))
        {
            xposition = 0f; yposition = 0f;
            score.pointR();

        }
    }

}
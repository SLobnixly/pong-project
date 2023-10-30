using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using TMPro;
using UnityEngine;


public class ball : MonoBehaviour
{
    private score score;
    public float xposition = 1f;
    public float yposition = 1f;
    public float xspeed = 7f;
    public float yspeed = 5f;
    
    


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
            xspeed = xspeed * -1.01f;
            Debug.Log("Colliders entering Collision up");
        }
        if (collision.gameObject.CompareTag("wall hor"))
        {
            yspeed = yspeed * -1.02f;
            Debug.Log("Colliders entering Collision down");
        }
        if (collision.gameObject.CompareTag("death R")) 
        {
            yspeed = 5f;
            xspeed = 7f;
            xposition = -7f; yposition = 0f;
            score.pointL();

        }
        if (collision.gameObject.CompareTag("death"))
        {
            yspeed = -5f;
            xspeed = -7f;
            xposition = 7f; yposition = 0f;
            score.pointR();
         

            }
    }

}
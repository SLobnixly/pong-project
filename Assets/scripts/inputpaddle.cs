using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class inputpaddle : MonoBehaviour
{//speed paddle
    public float speed = 3f;
    // checks if paddle is left or right
    public string LeftOrRight;

    void Start()
    {
        
    }


    void Update()
    {
        // left paddle code
        if (LeftOrRight == "left")
        {
            // when pressing w it moves at a certain speed up
         if (Input.GetKey(KeyCode.W))
            {// if under/above certain height move 
                if (transform.position.y <= 3.5f)
                {
                    speed = 7f;
                    Debug.Log("yes W is pressed");
                   transform.Translate(Vector3.up * speed * Time.deltaTime);

                }
                else if (transform.position.y == 3.5f) 
                { speed = 0f; }
           
            
         }

            // when pressing w it moves at a certain speed down

            else if (Input.GetKey(KeyCode.S))
         {
                // if under/above certain height move 
                if (transform.position.y >= -3.5f)
                {
                    speed = 7f;
                    Debug.Log("yes S is pressed");
                    transform.Translate(Vector3.down * speed * Time.deltaTime);

                }
                else if (transform.position.y == -3.5f) 
                { speed = 0f; }

            }
        }// right side code
        if (LeftOrRight == "right")
        {

            
            // when pressing up arrow it moves at a certain speed up
            if (Input.GetKey(KeyCode.UpArrow))
            {// if under/above certain height move 
                if (transform.position.y <= 3.5f)
                {
                    speed = 7f;
                    Debug.Log("yes uparrow is pressed");
                    transform.Translate(Vector3.up * speed * Time.deltaTime);

                }
                else if (transform.position.y == 3.5f) 
                { speed = 0f; }

            }


            // when pressing down arrow it moves at a certain speed down
            else if (Input.GetKey(KeyCode.DownArrow))
            {// if under/above certain height move 
                if (transform.position.y >= -3.5f)
                {
                    speed = 7f;
                    Debug.Log("yes downarrow is pressed up");
                    transform.Translate(Vector3.down * speed * Time.deltaTime);

                }
                else if (transform.position.y == -3.5f ) 
                    { 
                    
                    speed = 0f; }
                
            }
        }
        


    }
}

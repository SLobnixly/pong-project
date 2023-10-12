using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class inputpaddle : MonoBehaviour
{
    public float speed = 3f;
    public string LeftOrRight;

    void Start()
    {
        
    }


    void Update()
    {

        if (LeftOrRight == "left")
        {
         if (Input.GetKey(KeyCode.W))
         {
                if (transform.position.y <= 3.5f)
                {
                    speed = 7f;
                    Debug.Log("yes W is pressed");
                   transform.Translate(Vector3.up * speed * Time.deltaTime);

                }
                else if (transform.position.y == 3.5f) 
                { speed = 0f; }
           
            
         }



         else if (Input.GetKey(KeyCode.S))
         {

                if (transform.position.y >= -3.5f)
                {
                    speed = 7f;
                    Debug.Log("yes S is pressed");
                    transform.Translate(Vector3.down * speed * Time.deltaTime);

                }
                else if (transform.position.y == -3.5f) 
                { speed = 0f; }

            }
        }
        if (LeftOrRight == "right")
        {



            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (transform.position.y <= 3.5f)
                {
                    speed = 7f;
                    Debug.Log("yes uparrow is pressed");
                    transform.Translate(Vector3.up * speed * Time.deltaTime);

                }
                else if (transform.position.y == 3.5f) 
                { speed = 0f; }

            }



            else if (Input.GetKey(KeyCode.DownArrow))
            {
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

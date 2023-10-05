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
            Debug.Log("yes W is pressed down");
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            
         }
         else if (Input.GetKey(KeyCode.S))
         {
            Debug.Log("yew S is pressed down");
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        
         }
        }
        if (LeftOrRight == "right")
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Debug.Log("yes uparrow is pressed down");
                transform.Translate(Vector3.up * speed * Time.deltaTime);

            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                Debug.Log("yew downarrow is pressed down");
                transform.Translate(Vector3.down * speed * Time.deltaTime);

            }
        }


    }
}

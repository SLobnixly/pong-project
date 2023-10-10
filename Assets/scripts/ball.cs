using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class ball : MonoBehaviour
{
    public float xposition = 1f;
    public float yposition = 1f;
    public float xspeed = 1f;
    public float yspeed = 1f;
    public int pointr = 0;
    public int pointl = 0;
    public TMP_Text score;

    // Start is called before the first frame update
    void Start()
    {

        

        
    }

    // Update is called once per frame
    void Update()
    {
        
        xposition += + xspeed * Time.deltaTime;
        yposition += + yspeed * Time.deltaTime;
        transform.position = new Vector3(xposition, yposition, 0);
   
        if (transform.position.x >= 8f)
        {
            xposition = 0f; yposition = 0f;
            pointl =+ 1;
            Debug.Log("1 point for left");
       
                }
        
        if (transform.position.x <= -8f)
        {
            xposition = 0f; yposition = 0f;
            pointr = +1;
            Debug.Log("1 point for right");
            pointr.ToString();

        }
        
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
    }

}
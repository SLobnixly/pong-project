using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float xposition = 1f;
    public float yposition = 1f;
    public float xspeed = 1f;
    public float yspeed = 1f;

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
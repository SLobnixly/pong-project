using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scorewin : MonoBehaviour
{
   
    public TMP_Text scorewintext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // when enough points left wins
    public void scorewinL()
    {
        scorewintext.text = "left side has won!!!";
    }
    // when enough points right wins
    public void scorewinR()
    {
        scorewintext.text = "right side has won!!!";
    }
}

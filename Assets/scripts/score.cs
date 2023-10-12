using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using System.Net.NetworkInformation;
using System.Reflection;
using System;
using Unity.Burst.Intrinsics;
using Unity.VisualScripting;


public class score : MonoBehaviour
{ 
        public TMP_Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    public int scoreR;
    public int scoreL;
        public void pointL()
    {
        scoreL++;
        scoreText.text = scoreL + " - " + scoreR;
    }
    public void pointR()
    {
        scoreR++;
        scoreText.text = scoreL + " - " + scoreR;
    }
}
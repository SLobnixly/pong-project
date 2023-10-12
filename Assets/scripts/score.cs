using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;






public class score : MonoBehaviour
{ 
        public TMP_Text scoreText;
    
    private scorewin scorewin;
    // Start is called before the first frame update
    void Start()
    {
        scorewin = GameObject.FindObjectOfType<scorewin>();
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
        if (scoreL >= 5)
        { scorewin.scorewinL(); }
    }
    public void pointR()
    {
        scoreR++;
        scoreText.text = scoreL + " - " + scoreR;
        if (scoreR >= 5)
        { scorewin.scorewinR(); }
    }
}
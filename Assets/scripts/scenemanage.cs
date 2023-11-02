using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanage : MonoBehaviour
{
    // when button is pressed load scene
    public void start2Player()
    {
        SceneManager.LoadScene("normal");
    }
    // when button is pressed load scene
    public void playervsAI()
    {
        SceneManager.LoadScene("ai");
    }
    // when button is pressed load scene
    public void paddlevsAI()
    {
        SceneManager.LoadScene("2paddle");
    }
}

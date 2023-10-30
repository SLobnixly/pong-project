using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanage : MonoBehaviour
{
    public void start2Player()
    {
        SceneManager.LoadScene("normal");
    }
    public void playervsAI()
    {
        SceneManager.LoadScene("ai");
    }
    public void paddlevsAI()
    {
        SceneManager.LoadScene("2paddle");
    }
}

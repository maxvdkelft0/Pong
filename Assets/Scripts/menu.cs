using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void PlayNormal1()
    {
        SceneManager.LoadScene("OnePlayerPong");
    }
    public void PlayNormal2()
    {
        SceneManager.LoadScene("TwoPlayerPong");
    }
    public void PlayHardcore()
    {
        SceneManager.LoadScene("HardcoreTwoPlayerPong");
    }
}
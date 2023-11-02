using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Select normal mode for 1 player
    public void PlayNormal1()
    {
        SceneManager.LoadScene("OnePlayerPong");
        Debug.Log("Select normal mode for 1 player");
    }

    // Select normal mode for 2 players
    public void PlayNormal2()
    {
        SceneManager.LoadScene("TwoPlayerPong");
        Debug.Log("Select normal mode for 2 players");

    }

    // Select hardcore mode for 2 players
    public void PlayHardcore()
    {
        SceneManager.LoadScene("HardcoreTwoPlayerPong");
        Debug.Log("Select harcore mode for 2 players");
    }
}
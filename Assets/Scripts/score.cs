using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour
{
    public Text Scoreboard;
    public GameObject ball;
    public GameObject wall1;
    public GameObject wall2;

    private int Bat_1_Score = 0;
    private int Bat_2_Score = 0;

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("ball"); 
        wall1 = GameObject.Find("vertical1");
        wall2 = GameObject.Find("vertical1");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (wall1)
        {
            Debug.Log("Touched wall 1");
            Bat_1_Score++;
        }
        if (wall2)
        {
            Debug.Log("Touched wall 2");
            Bat_2_Score
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}

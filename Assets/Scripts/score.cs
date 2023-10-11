using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour
{
    public TMPro.TMP_Text text;
    private GameObject ball;
    private int scoreRight = 0;
    private int scoreLeft = 0;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("ball");
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.transform.position.x >= 9f)
        {
            scoreRight++;
        }
        if (ball.transform.position.x <= -9f)
        {
            scoreLeft++;
        }
        text.text = scoreRight.ToString() + " - " + scoreLeft.ToString();
        Debug.Log(scoreRight + " , " + scoreLeft);
    }

}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ball : MonoBehaviour
{

    #region Variables
    //ball variables
    public float Xposition = 0f;
    public float Yposition = 0f;
    public float xSpeed;
    public float ySpeed;

    //score variables
    public TMP_Text scoreField;
    private int rightScore = 0;
    private int leftScore = 0;
    public int topScore = 10;
    #endregion

    #region resetBallHandler function
    private void resetBallHandler(string leftOrRight)
    {
        Xposition = 0;
        Yposition = 0;
        scoreField.text = leftScore.ToString() + " - " + rightScore.ToString();
        if(leftOrRight == "left")
        {
            xSpeed = 3f;
            ySpeed = 3f;
        }
        else if (leftOrRight == "right")
        {
            xSpeed = -3f;
            ySpeed = 3f;
        }
    }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Xposition, Yposition, 0);
        xSpeed = 4.5f;
        ySpeed = 4.5f;
    }

    // Update is called once per frame
    void Update()
    {
        Xposition += xSpeed * Time.deltaTime;
        Yposition += ySpeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);
        if(leftScore >= topScore)
        {
            scoreField.text = "Left player has won!";
        }
        else if (rightScore >= topScore)
        {
            scoreField.text = "Right player has won!";

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            ySpeed = ySpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("leftWall"))
        {
            rightScore++;
            resetBallHandler("left");
        }
        else if (collision.gameObject.CompareTag("rightWall"))
        {
            leftScore++;
            resetBallHandler("right");
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            //Every time the ball hits the padels it goes faster
            xSpeed = xSpeed * -1.3f;
        }
            
    }
}

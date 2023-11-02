using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pongBot : MonoBehaviour
{
    // Vertical speed
    public float ySpeed = 3f;
    // Vertical position
    public float yPosition = 0;
    // identifing the ball
    public GameObject ball;

    // Update is called once per frame
    void Update()
    {
        // Every frame the gameobject (bot) follows the y position of the ball.
        transform.position = new Vector3(transform.position.x, ball.transform.position.y/3, transform.position.z);
    }
}


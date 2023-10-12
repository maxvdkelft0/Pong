using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputPaddle : MonoBehaviour
{

    #region Variables
    public float speed = 3f;
    public string leftOrRight;
    #endregion

    #region inputHandler Function
    void inputHandler(KeyCode up, KeyCode down)
    {
        if (Input.GetKey(up) && transform.position.y <= 3.95f)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down) && transform.position.y >= -3.95f)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
    #endregion

    // Update is called once per frame
    void Update()
    {
        if (leftOrRight == "left")
        {
            inputHandler(KeyCode.W, KeyCode.S);
        }
        else if (leftOrRight == "right")
        {
            inputHandler(KeyCode.UpArrow, KeyCode.DownArrow);
        }
    }
}

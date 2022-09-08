using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public Rigidbody rigidbody; //calls rigid body
    public float speed; //a float to change speed if needed

    void Update()
    {
        // inputs for moving up,down,left and right
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddForce(-speed * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(speed * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(0, 0, -speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(0, 0, speed * Time.deltaTime); //adding force in direction relative to w a s d

        }
    }
}

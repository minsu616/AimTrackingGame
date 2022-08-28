using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpPower = 2.0f;

    public float jumpCount;
    bool isGround = false;

    // Player speed
    void Start()
    {
        jumpCount = 0;
    }
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(speed, 0, 0) * Time.deltaTime;
            // Front
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(speed * -1, 0, 0) * Time.deltaTime;
            // Back
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(0, 0, speed) * Time.deltaTime;
            // Left
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(0, 0, speed * -1) * Time.deltaTime;
            // Right
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = transform.position + new Vector3(0, jumpPower, 0) * Time.deltaTime;
            // Jump
        }
    }
}

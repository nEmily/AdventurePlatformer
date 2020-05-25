using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject cam;
    Rigidbody2D rb;
    public float jumpSpeed = 8.0f;
    public float speed = 6.0f;
    public float gravity = 20.0f;
    public float cameraOffset = 4.97f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cameraOffset = cam.transform.position.x - transform.position.x;
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpSpeed);
        }

        rb.AddForce(Vector3.right * speed);
        cam.transform.position = new Vector3(transform.position.x + cameraOffset, cam.transform.position.y, cam.transform.position.z);
    }

    // Checks if we're grounded -- haven't decided how to do this yet
    bool IsGrounded()
    {
        return true;
    }
}

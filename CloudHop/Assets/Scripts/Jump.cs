using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float jumpForce = 20;

    private bool canJump;

    // Update is called once per frame
    void Update()
    {
        if (rigidBody.velocity.y > -.01 && rigidBody.velocity.y < .01) canJump = true;
        else canJump = false;

        if (Input.GetButtonDown("Jump") && canJump)
        {
            rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}

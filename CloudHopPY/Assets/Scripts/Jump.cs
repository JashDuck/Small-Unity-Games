using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rigidBody;

    private const int jumpStrength = 15;
    private bool canJump;

    // Update is called once per frame
    void Update()
    {
        if (rigidBody.velocity.y > -.01 && rigidBody.velocity.y < .01) canJump = true;
        else canJump = false;
        
        if (Input.GetButtonDown("Jump") && canJump)
            rigidBody.AddForce(Vector2.up * jumpStrength, ForceMode2D.Impulse);
    }
}

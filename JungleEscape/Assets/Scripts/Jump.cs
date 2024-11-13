using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody rigidBody;

    private const float jumpForce = 5.7f;
    private const float fallMultiplier = 1.5f;
    public bool isGrounded;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, .15f);

        if(Input.GetButtonDown("Jump") && isGrounded)
            rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        if (rigidBody.velocity.y < 0)
            rigidBody.velocity += fallMultiplier * Time.deltaTime * Physics.gravity;
    }
}


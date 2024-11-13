using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jump : MonoBehaviour
{
    Rigidbody Rigidbody;

    float jumpForce = 5.7f;
    float fallMultiplier = 1.5f; 

    public bool isGrounded;
    public float distToGround = 0.15f;

    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
        isGrounded = true;
    }

    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, distToGround);
        Debug.DrawRay(transform.position, Vector3.down * distToGround, Color.red);

        //jump movement
        if(Input.GetButtonDown("Jump") && isGrounded){
            Rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        
        //increase gravity when falling
        if (Rigidbody.velocity.y < 0){
            Rigidbody.velocity += Physics.gravity * fallMultiplier * Time.deltaTime;
        }
    }
}

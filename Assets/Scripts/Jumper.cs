using System;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField] 
    private float jumpForce;
    
    private Collider col;
    private Rigidbody rb;
    private float distanceToGround;



    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
        distanceToGround = col.bounds.extents.y;
    }
    private bool isGrounded => Physics.Raycast(transform.position, -Vector3.up, distanceToGround);
    
    private void Jump()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}

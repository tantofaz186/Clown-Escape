using System;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField] 
    private float jumpForce;
    
    private Collider col;
    private Rigidbody rb;
    private float distanceToGround;

    private SwipeDetection inputDetection;
    private void Awake()
    {
        inputDetection = SwipeDetection.Instance;
    }

    private void OnEnable()
    {
        inputDetection.OnSwipeUp += Jump;

    }

    private void OnDisable()
    {
        inputDetection.OnSwipeUp -= Jump;
        
    }

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

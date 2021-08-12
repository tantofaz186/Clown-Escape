using UnityEngine;

public class Jumper : MonoBehaviour
{
    public float jumpForce;
    private Collider col;
    private Rigidbody rb;
    private float distanceToGround;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
        distanceToGround = col.bounds.extents.y;
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
    
    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, distanceToGround);
    }
}

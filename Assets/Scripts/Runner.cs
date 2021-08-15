using UnityEngine;

public class Runner : MonoBehaviour
{
    
    [SerializeField] 
    private float acceleration = 11;
    [SerializeField] 
    private float maxSpeed = 10;
    
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        
        if (Mathf.Abs(rb.velocity.x) < maxSpeed)
            rb.AddForce(transform.forward * acceleration, ForceMode.Acceleration);
        
    }
    
}

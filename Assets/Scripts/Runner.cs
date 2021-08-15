using UnityEngine;

public class Runner : MonoBehaviour
{
    
    [SerializeField] 
    private float acceleration;
    [SerializeField] 
    private float maxSpeed;
    
    private Rigidbody rb;

    #region Unity Events

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        
        if (Mathf.Abs(rb.velocity.x) < maxSpeed)
            rb.AddForce(transform.forward * acceleration, ForceMode.Acceleration);
        
    }

    #endregion
    
    
}

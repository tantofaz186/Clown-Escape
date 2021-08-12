using UnityEngine;

public class Runner : MonoBehaviour
{
    #region Public Variables
    
    public float acceleration;
    public float maxSpeed;

    #endregion
    
    #region Private Variables
    
    private Rigidbody rb;
    
    #endregion

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

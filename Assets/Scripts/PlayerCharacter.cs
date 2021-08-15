using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour, ISlider, IJumper
{
    [SerializeField] private float jumpForce = 9.5f;
    
    private Collider col;
    private Rigidbody rb;
    private SwipeDetection inputDetection;
    private float distanceToGround;
    
    private bool isGrounded => Physics.Raycast(transform.position, -Vector3.up, distanceToGround);

    private void Awake()
    {
        inputDetection = SwipeDetection.Instance;
    }
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
        distanceToGround = col.bounds.extents.y;
    }
    private void OnEnable()
    {
        inputDetection.OnSwipeUp += Jump;

    }

    private void OnDisable()
    {
        inputDetection.OnSwipeUp -= Jump;
        
    }
    public void Slide()
    {
        throw new System.NotImplementedException();
    }



    public bool IsGrounded(Collider col)
    {
        throw new System.NotImplementedException();
    }

    public float DisTanceToGround(Collider col)
    {
        return col.bounds.extents.y;
    }
    
    public void Jump()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}

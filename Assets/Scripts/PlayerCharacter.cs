using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class PlayerCharacter : MonoBehaviour
{
    [SerializeField] private float jumpForce = 9.5f;

    [SerializeField] private float acceleration = 11;

    [SerializeField] private float maxSpeed = 10;


    private Collider col;
    private Rigidbody rb;
    private SwipeDetection inputDetection;

    private float distanceToGround;

    private bool isGrounded => Physics.Raycast(transform.position, -Vector3.up, distanceToGround);

    #region Unity Events

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
        inputDetection.OnSwipeDown += Slide;
    }

    private void OnDisable()
    {
        inputDetection.OnSwipeUp -= Jump;
        inputDetection.OnSwipeDown -= Slide;
    }

    private void FixedUpdate()
    {
        Run();
    }

    #endregion


    private void Slide()
    {
        throw new System.NotImplementedException();
    }


    private void Jump()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }


    private void Run()
    {
        if (Mathf.Abs(rb.velocity.x) < maxSpeed)
            rb.AddForce(transform.forward * acceleration, ForceMode.Acceleration);
    }
}
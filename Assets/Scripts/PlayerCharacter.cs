using System;
using System.Collections;
using System.Collections.Generic;
using Animations;
using Interfaces;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour, 
    IJumper, IRunner, IAttacker
{
    
    [SerializeField] private float jumpForce = 9.5f;
    [SerializeField] private float acceleration = 11;
    [SerializeField] private float maxSpeed = 10;
    [SerializeField] private Collider baseCol;
    [SerializeField] private Collider slideCol;
    
    private Rigidbody rb;
    //private SwipeDetection inputDetection;
    
    [SerializeField] private GameObject weapon;
    private Collider weaponCol;
    
    public float distanceToGround;

    public bool isGrounded => Physics.Raycast(transform.position, -Vector3.up, distanceToGround);
    public float rb_Speed => rb.velocity.x;
    public float MaxSpeed => maxSpeed;
    
    #region Unity Events

    private void Awake()
    {
        //inputDetection = SwipeDetection.Instance;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        weaponCol = weapon.GetComponent<Collider>();
        distanceToGround = baseCol.bounds.extents.y;
        
    }
    private void OnEnable()
    {
    }

    private void OnDisable()
    {

    }

    private void FixedUpdate()
    {
        Run();
    }

    #endregion
    
    public void BeginSlide()
    {
        baseCol.enabled = false;
    }

    public void EndSlide()
    {
        baseCol.enabled = true;
    }
    public void OnBeginJump()
    {
        Jump();
    }
    public void Jump()
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

    void IRunner.Run()
    {
        Run();
    }

    void IAttacker.Attack()
    {
        throw new System.NotImplementedException();
    }

    public void ChangeMaxSpeed(float maxSpeedModifier, float time)
    {
        StartCoroutine(ChangeMaxSpeedCourotine(maxSpeedModifier, time));
    }
    IEnumerator ChangeMaxSpeedCourotine(float maxSpeedModifier, float time)
    {
        maxSpeed += maxSpeedModifier;
        Debug.Log("max speed aumentada");
        yield return new WaitForSeconds(time);
        maxSpeed -= maxSpeedModifier;
        Debug.Log("max speed reduzida");
    }
    
}
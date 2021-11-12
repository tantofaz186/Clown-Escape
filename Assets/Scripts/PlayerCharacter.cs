using System;
using System.Collections;
using Interfaces;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour, 
    IJumper, IRunner, IAttacker
{

    private Animator m_Animator;
    private static readonly int s_Attacking = Animator.StringToHash("Attack");
    public event Action OnHitWall;
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
        m_Animator = GetComponent<Animator>();
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

    public void HitWall()
    {
        if (!m_Animator.GetBool(s_Attacking))
        {        
            rb.velocity /= 16;
            rb.Sleep();
            rb.WakeUp();
            OnHitWall?.Invoke();
        }
    }

    private float tempoTravado = 0;
    private float tempoMaximoTravado = 1.2f;
    private void OnCollisionStay(Collision other)
    {
        if (gameObject.layer == LayerMask.NameToLayer("Obstaculo"))
        {
            tempoTravado += Time.deltaTime;
            if (tempoTravado >= tempoMaximoTravado)
            {
                rb.AddForce((-1 * transform.forward) / 16, ForceMode.Impulse);
                rb.Sleep();
                rb.WakeUp();
                tempoTravado = 0;
            }
        }
    }

}
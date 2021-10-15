using System;
using System.Collections;
using Controllers;
using UnityEngine;

namespace Animations
{
    [RequireComponent(typeof(PlayerCharacter))]
    [RequireComponent(typeof(Animator))]
    public class xbotAnimController : MonoBehaviour
    {
        private Animator m_Animator;
        private PlayerCharacter m_Player;
        private SwipeDetection inputDetection;

        private static readonly int s_Slide = Animator.StringToHash("Slide");
        private static readonly int s_Attack = Animator.StringToHash("Attack");
        private static readonly int s_Jump = Animator.StringToHash("Jump");
        private static readonly int s_IsGrounded = Animator.StringToHash("IsGrounded");
        private static readonly int s_Roll = Animator.StringToHash("Roll");

        // Start is called before the first frame update
        private void Awake()
        {
            inputDetection = SwipeDetection.Instance;
            m_Animator = GetComponent<Animator>();
            m_Player = GetComponent<PlayerCharacter>();
        }
        void SetRollTrigger()
        {
            m_Animator.SetTrigger(s_Roll);
        }        
        void SetSlideTrigger()
        {
            m_Animator.SetTrigger(s_Slide);
        }
        void SetAttackTrigger()
        {
            m_Animator.SetTrigger(s_Attack);
        }
        void SetJumpTrigger()
        {
            m_Animator.SetTrigger(s_Jump);
        }

        public void OnBeginJump()
        {
            StartCoroutine(WaitUntilGrounded());
        }
        private IEnumerator WaitUntilGrounded()
        {
            yield return new WaitUntil(() => !m_Player.isGrounded);
            m_Animator.SetBool(s_IsGrounded, m_Player.isGrounded);
            yield return new WaitUntil(() => m_Player.isGrounded);
            m_Animator.SetBool(s_IsGrounded, m_Player.isGrounded);
            Debug.Log("player is now grounded");
        }
        
        private void OnEnable()
        {
            inputDetection.OnSwipeDown += SetSlideTrigger;
            inputDetection.OnSwipeRight += SetAttackTrigger;
            inputDetection.OnSwipeUp += SetJumpTrigger;
            m_Player.OnHitWall += SetRollTrigger;

        }
        private void OnDisable()
        {
            inputDetection.OnSwipeDown -= SetSlideTrigger;
            inputDetection.OnSwipeRight -= SetAttackTrigger;
            inputDetection.OnSwipeUp -= SetJumpTrigger;
            m_Player.OnHitWall -= SetRollTrigger;


        }
        void Start()
        {
            m_Animator.SetBool(s_IsGrounded, m_Player.isGrounded);
        }
    }
}

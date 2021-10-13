using System;
using UnityEngine;

namespace Animations
{
    public class xbotAnimController : MonoBehaviour
    {
        private Animator m_Animator;
        private SwipeDetection inputDetection;

        private static readonly int s_Slide = Animator.StringToHash("Slide");
        private static readonly int s_Attack = Animator.StringToHash("Attack");
        private static readonly int s_Jump = Animator.StringToHash("Jump");
        private static readonly int s_IsGrounded = Animator.StringToHash("IsGrounded");

        // Start is called before the first frame update
        private void Awake()
        {
            inputDetection = SwipeDetection.Instance;
        }
        void SetJumpTrigger()
        {
            m_Animator.SetTrigger(s_Jump);
        }
        void SetSlideTrigger()
        {
            m_Animator.SetTrigger(s_Slide);
            
        }
        public void EndSlide()
        {
            m_Animator.ResetTrigger(s_Slide);
        }
        void SetAttackTrigger()
        {
            m_Animator.SetTrigger(s_Attack);
            
        }
        private void OnEnable()
        {
            inputDetection.OnSwipeDown += SetSlideTrigger;
            inputDetection.OnSwipeRight += SetAttackTrigger;
            inputDetection.OnSwipeUp += SetJumpTrigger;

        }

        private void OnDisable()
        {
            inputDetection.OnSwipeDown -= SetSlideTrigger;
            inputDetection.OnSwipeRight -= SetAttackTrigger;
            inputDetection.OnSwipeUp -= SetJumpTrigger;

        }
        void Start()
        {
            m_Animator = GetComponent<Animator>();
        }
    }
}

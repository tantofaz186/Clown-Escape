using System;
using UnityEngine;

namespace Animations
{
    public class xbotAnimController : MonoBehaviour
    {
        private Animator m_Animator;
        private SwipeDetection inputDetection;

        private static readonly int s_Slide = Animator.StringToHash("Slide");
        private static readonly int s_Roll = Animator.StringToHash("Roll");
        private static readonly int s_Attack = Animator.StringToHash("Attack");

        // Start is called before the first frame update
        private void Awake()
        {
            inputDetection = SwipeDetection.Instance;
        }
        void SetRollTrigger()
        {
            m_Animator.SetTrigger(s_Roll);
            
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
            
        }

        private void OnDisable()
        {
            inputDetection.OnSwipeDown -= SetSlideTrigger;
            inputDetection.OnSwipeRight -= SetAttackTrigger;
        }
        void Start()
        {
            m_Animator = GetComponent<Animator>();
        }
    }
}

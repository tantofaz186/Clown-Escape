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
        private void OnEnable()
        {
            inputDetection.OnSwipeLeft += SetRollTrigger;
            inputDetection.OnSwipeDown += SetSlideTrigger;
            
        }

        private void OnDisable()
        {
            inputDetection.OnSwipeLeft -= SetRollTrigger;
            inputDetection.OnSwipeDown -= SetSlideTrigger;
        }
        void Start()
        {
            m_Animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}

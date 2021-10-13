using System;
using UnityEngine;

namespace Controllers
{
    public class SwipeDetection : Singleton<SwipeDetection>
    {
        public event Action OnSwipeUp;
        public event Action OnSwipeDown;
        public event Action OnSwipeLeft;
        public event Action OnSwipeRight;
        public event Action OnTap;


        [SerializeField] private float maxTime = 1f;
        [SerializeField] private float minimumDistance = 0.2f;
        [SerializeField] private float angleThreshold = 15f;

        private InputManager inputManager;

        private Vector2 startPos;
        private Vector2 endPos;
        private float startTime;
        private float endTime;

        private bool isSwipe =>
            Vector3.Distance(endPos, startPos) >= minimumDistance && endTime - startTime <= maxTime;
        private bool isTap =>
            Vector3.Distance(endPos, startPos) < minimumDistance && endTime - startTime <= maxTime;
    
        private void Awake()
        {
            inputManager = InputManager.Instance;
        }

        private void OnEnable()
        {
            inputManager.OnStartTouch += SwipeStart;
            inputManager.OnEndTouch += SwipeEnd;
        }

        private void OnDisable()
        {
            inputManager.OnStartTouch -= SwipeStart;
            inputManager.OnEndTouch -= SwipeEnd;
        }

        private void SwipeStart(Vector2 pos, float time)
        {
            startPos = pos;
            startTime = time;
        }

        private void SwipeEnd(Vector2 pos, float time)
        {
            endPos = pos;
            endTime = time;
            DetectSwipeType();
        }

        private void DetectSwipeType()
        {
            if (isSwipe)
            {
                Debug.DrawLine(startPos, endPos, Color.red, 6f, false);
                var vectorDir = (endPos - startPos).normalized;
                if (Vector2.Angle(vectorDir, Vector2.up) <= angleThreshold)
                {
                    Debug.Log("up");
                    OnSwipeUp?.Invoke();
                }
                else if (Vector2.Angle(vectorDir, Vector2.down) <= angleThreshold)
                {
                    Debug.Log("down");
                    OnSwipeDown?.Invoke();
                }
                else if (Vector2.Angle(vectorDir, Vector2.left) <= angleThreshold)
                {
                    Debug.Log("left");
                    OnSwipeLeft?.Invoke();
                }
                else if (Vector2.Angle(vectorDir, Vector2.right) <= angleThreshold)
                {
                    Debug.Log("right");
                    OnSwipeRight?.Invoke();
                }
            }
            else if (isTap)
            {
                OnTap?.Invoke();
            }
        }
    }
}
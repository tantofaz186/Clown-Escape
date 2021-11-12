using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Controllers
{
    public class InputEventHandler : Singleton<InputEventHandler>
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
            inputManager.OnKeyPress += KeyPressHandler;
        }

        private void OnDisable()
        {
            inputManager.OnStartTouch -= SwipeStart;
            inputManager.OnEndTouch -= SwipeEnd;
            inputManager.OnKeyPress -= KeyPressHandler;
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
            var actionType = DetectActionType();
            actionType?.Invoke();
        }


        private Action DetectActionType()
        {

            Action actionType = null;
            if (isSwipe)
            {
                Debug.DrawLine(startPos, endPos, Color.red, 6f, false);
                var vectorDir = (endPos - startPos).normalized;
                if (Vector2.Angle(vectorDir, Vector2.up) <= angleThreshold)
                {
                    //OnSwipeUp?.Invoke();
                    actionType = OnSwipeUp;
                }
                else if (Vector2.Angle(vectorDir, Vector2.down) <= angleThreshold)
                {
                    //OnSwipeDown?.Invoke();
                    actionType = OnSwipeDown;
                }
                else if (Vector2.Angle(vectorDir, Vector2.left) <= angleThreshold)
                {
                    //OnSwipeLeft?.Invoke();
                    actionType = OnSwipeLeft;
                }
                else if (Vector2.Angle(vectorDir, Vector2.right) <= angleThreshold)
                {
                    //OnSwipeRight?.Invoke();
                    actionType = OnSwipeRight;
                }
            }
            else if (isTap)
            {
                actionType = OnTap;
            }

            return actionType;
        }
        private void KeyPressHandler(Key key)
        {
            Action keyboardAction = null;
            switch (key)
            {
                case Key.Space:
                case Key.W:
                    keyboardAction = OnSwipeUp;
                    break;
                case Key.S:
                    keyboardAction = OnSwipeDown;
                    break;
                case Key.A:
                    keyboardAction = OnSwipeLeft;
                    break;
                case Key.D:
                    keyboardAction = OnSwipeRight;
                    break;

            }
            keyboardAction?.Invoke();
        }
    }
}
using System;
using UnityEngine.InputSystem;

namespace Controllers
{
    public class KeyboardInput : Singleton<KeyboardInput>
    {
        private SwipeDetection swipeDetector;
        private InputManager inputManager;

        private void Awake()
        {
            swipeDetector = SwipeDetection.Instance;
            inputManager = InputManager.Instance;
        }

        private void OnEnable()
        {
            inputManager.OnKeyPress += KeyPressHandler;
        }

        private void KeyPressHandler(Key key)
        {
            switch (key)
            {
                case Key.W:
                    break;
                case Key.S:
                    break;
                case Key.D:
                    break;
                case Key.A:
                    break;
                case Key.Space:
                    break;
            }
        }

        private void OnDisable()
        {
            inputManager.OnKeyPress -= KeyPressHandler;
        }
    }
}
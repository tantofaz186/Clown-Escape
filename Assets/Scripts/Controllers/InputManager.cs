using UnityEngine;
using UnityEngine.InputSystem;

namespace Controllers
{
    [DefaultExecutionOrder(-1)]
    public class InputManager : Singleton<InputManager>
    {
        #region Events
        public delegate void StartedTouch(Vector2 pos, float time);
        public event StartedTouch OnStartTouch;
        public delegate void EndedTouch(Vector2 pos, float time);
        public event EndedTouch OnEndTouch;

        public delegate void PressedKey(Key key);

        public event PressedKey OnKeyPress;

        #endregion

    
        private PlayerInput playerInput;
    
        private void Awake()
        {
            playerInput = new PlayerInput();
        }

        private void OnEnable()
        {
            playerInput.Enable();
            playerInput.Touch.PrimaryContact.started += StartedPrimaryTouch;
            playerInput.Touch.PrimaryContact.canceled += EndedPrimaryTouch;
            playerInput.MousePort.PrimaryContact.started += StartedPrimaryTouchWithMouse;
            playerInput.MousePort.PrimaryContact.canceled += EndedPrimaryTouchWithMouse;
            playerInput.TecladoPort.Teclas.performed += PressedKeyboardKey;
        }


        private void OnDisable()
        {
            playerInput.Disable();
            playerInput.Touch.PrimaryContact.started -= StartedPrimaryTouch;
            playerInput.Touch.PrimaryContact.canceled -=EndedPrimaryTouch;
            playerInput.MousePort.PrimaryContact.started -= StartedPrimaryTouchWithMouse;
            playerInput.MousePort.PrimaryContact.canceled -= EndedPrimaryTouchWithMouse;
            playerInput.TecladoPort.Teclas.performed -= PressedKeyboardKey;
        }

        private void StartedPrimaryTouchWithMouse(InputAction.CallbackContext context) =>
            OnStartTouch?.Invoke(playerInput.MousePort.PrimaryPosition.ReadValue<Vector2>(), (float)context.startTime);
        private void EndedPrimaryTouchWithMouse(InputAction.CallbackContext context) =>
            OnEndTouch?.Invoke(playerInput.MousePort.PrimaryPosition.ReadValue<Vector2>(), (float)context.time);
        private void StartedPrimaryTouch(InputAction.CallbackContext context)=>
            OnStartTouch?.Invoke(playerInput.Touch.PrimaryPosition.ReadValue<Vector2>(), (float)context.startTime);
        private void EndedPrimaryTouch(InputAction.CallbackContext context) =>
            OnEndTouch?.Invoke(playerInput.Touch.PrimaryPosition.ReadValue<Vector2>(), (float)context.time);
        private void PressedKeyboardKey(InputAction.CallbackContext context) =>
            OnKeyPress?.Invoke(playerInput.TecladoPort.Teclas.ReadValue<Key>());
    }
}

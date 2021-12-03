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
        public delegate void TouchedWithMultipleFingers(float time);

        public event TouchedWithMultipleFingers FourTouch;
        public event TouchedWithMultipleFingers FiveTouch;

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
            playerInput.Touch.FourContacts.performed += FourContactsOnperformed;
            playerInput.Touch.FiveContacts.performed += FiveContactsOnperformed;
            playerInput.TecladoPort.Invincibility.performed += InvincibilityOnperformed;
            playerInput.TecladoPort.LevelSelect.performed += LevelSelectOnperformed;
        }



        private void OnDisable()
        {
            playerInput.Disable();
            playerInput.Touch.PrimaryContact.started -= StartedPrimaryTouch;
            playerInput.Touch.PrimaryContact.canceled -= EndedPrimaryTouch;
            playerInput.MousePort.PrimaryContact.started -= StartedPrimaryTouchWithMouse;
            playerInput.MousePort.PrimaryContact.canceled -= EndedPrimaryTouchWithMouse;
            playerInput.TecladoPort.Teclas.performed -= PressedKeyboardKey;
            playerInput.Touch.FourContacts.performed -= FourContactsOnperformed;
            playerInput.Touch.FiveContacts.performed -= FiveContactsOnperformed;
            playerInput.TecladoPort.Invincibility.performed -= InvincibilityOnperformed;
            playerInput.TecladoPort.LevelSelect.performed -= LevelSelectOnperformed;
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
        private void FourContactsOnperformed(InputAction.CallbackContext context) => FourTouch?.Invoke((float)context.time);
        private void FiveContactsOnperformed(InputAction.CallbackContext context) => FiveTouch?.Invoke((float)context.time);
        private void LevelSelectOnperformed(InputAction.CallbackContext context) => FourTouch?.Invoke((float)context.time);
        private void InvincibilityOnperformed(InputAction.CallbackContext context) => FiveTouch?.Invoke((float)context.time);
    }
}

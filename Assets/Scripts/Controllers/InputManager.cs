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
        #endregion

    
        private PlayerInput playerInput;
    
        private void Awake()
        {
            playerInput = new PlayerInput();
        }

        private void OnEnable()
        {
            playerInput.Enable();
        }

        private void OnDisable()
        {
            playerInput.Disable();
        }
    
        private void Start()
        {
            playerInput.Touch.PrimaryContact.started += context => StartedPrimaryTouch(context);
            playerInput.Touch.PrimaryContact.canceled += context => EndedPrimaryTouch(context);
        }

        private void StartedPrimaryTouch(InputAction.CallbackContext context)=>
            OnStartTouch?.Invoke(playerInput.Touch.PrimaryPosition.ReadValue<Vector2>(), (float)context.startTime);
    
        private void EndedPrimaryTouch(InputAction.CallbackContext context) =>
            OnEndTouch?.Invoke(playerInput.Touch.PrimaryPosition.ReadValue<Vector2>(), (float)context.time);
    
    }
}

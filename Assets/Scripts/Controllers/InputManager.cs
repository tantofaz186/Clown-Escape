using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[DefaultExecutionOrder(-1)]
public class InputManager : Singleton<InputManager>
{

 
    
    public delegate void StartedTouch(Vector2 pos, float time);
    public event StartedTouch OnStartTouch;
    public delegate void EndedTouch(Vector2 pos, float time);
    public event EndedTouch OnEndTouch;
    
    
    
    
    
    private PlayerInput playerInput;
    private Camera mainCamera;
    private void Awake()
    {
        playerInput = new PlayerInput();
        mainCamera = Camera.main;
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

    private void StartedPrimaryTouch(InputAction.CallbackContext context)
    {
        OnStartTouch?.Invoke(mainCamera.ScreenToWorldPoint(playerInput.Touch.PrimaryPosition.ReadValue<Vector2>()), (float)context.startTime);
    }

    private void EndedPrimaryTouch(InputAction.CallbackContext context)
    {
        OnEndTouch?.Invoke( mainCamera.ScreenToWorldPoint(playerInput.Touch.PrimaryPosition.ReadValue<Vector2>()), (float)context.time);
    }
}

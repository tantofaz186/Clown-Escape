using System;
using Controllers;
using UnityEngine;

public class Cheats : MonoBehaviour
{
    private InputManager inputManager;

    private void Awake()
    {
        inputManager = InputManager.Instance;
    }
    
}

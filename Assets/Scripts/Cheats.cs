using System;
using Controllers;
using UnityEngine;
using UnityEngine.InputSystem;

public class Cheats : MonoBehaviour
{
    private InputManager inputManager;
    private UIController uiController;
    private AudioSource audioSource;
    [SerializeField] private AudioClip CheatTriggerAudioClip;

    private void Awake()
    {
        inputManager = InputManager.Instance;
        uiController = UIController.Instance;
        audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        inputManager.FourTouch += UnlockLevelSelectScreen;
        inputManager.FiveTouch += Invincibility;
    }
    private void OnDisable()
    {
        inputManager.FourTouch -= UnlockLevelSelectScreen;
        inputManager.FiveTouch -= Invincibility;
    }
    
    private void Invincibility()
    {
        Debug.Log("Invincibility");
        CheatTrigger();
        GameOverOnCollision.playerIsInvincible = true;
    }

    private void UnlockLevelSelectScreen()
    {
        CheatTrigger();
        uiController.LevelSelect();
    }

    private void CheatTrigger()
    {
        audioSource.PlayOneShot(CheatTriggerAudioClip);
    }
}
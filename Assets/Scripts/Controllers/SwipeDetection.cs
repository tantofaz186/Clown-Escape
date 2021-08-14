using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetection : MonoBehaviour
{
    [SerializeField] 
    private float maxTime = 1f;
    [SerializeField] 
    private float minimumDistance = 0.2f;
    
    
    private InputManager inputManager;

    private Vector2 startPos;
    private Vector2 endPos;
    private float startTime;
    private float endTime;
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
    }

    private void DetectSwipe()
    {
        if (Vector3.Distance(endPos, startPos) >= minimumDistance 
            && endTime - startTime <= maxTime)
        {
            Debug.DrawLine(startPos, endPos, Color.red,2f);
        }
    }
}
public enum SwipeType
{
    Up,
    Down,
    Left,
    Right,
    Diagonal
};

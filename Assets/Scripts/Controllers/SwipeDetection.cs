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
    [SerializeField]
    private float angleThreshold = 15f;
    
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
        DetectSwipeType();
    }

    private SwipeType DetectSwipeType()
    {
        if (Vector3.Distance(endPos, startPos) >= minimumDistance 
            && endTime - startTime <= maxTime)
        {
            Debug.DrawLine(startPos, endPos, Color.red,6f, false);
            var vectorDir = (endPos - startPos).normalized;
            if (Vector2.Angle(vectorDir, Vector2.up) <= angleThreshold)
            {
                Debug.Log("up");
                return SwipeType.Up;
            }

            if (Vector2.Angle(vectorDir, Vector2.down) <= angleThreshold)
            {
                Debug.Log("down");
                return SwipeType.Down;
            }

            if (Vector2.Angle(vectorDir, Vector2.left) <= angleThreshold)
            {
                Debug.Log("left");
                return SwipeType.Left;
            }

            if (Vector2.Angle(vectorDir, Vector2.right) <= angleThreshold)
            {
                Debug.Log("right");
                return SwipeType.Right;
            }
        }
        return default;
    }
}

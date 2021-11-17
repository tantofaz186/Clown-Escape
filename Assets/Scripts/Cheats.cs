using System.Collections.Generic;
using Controllers;
using UnityEngine;

public class Cheats : MonoBehaviour
{
    private InputEventHandler inputDetection;
    private List<List<Inputs>> cheatList;
    private int[] cheatProgress;
    private void Awake()
    {
        cheatList = new List<List<Inputs>>()
        {
            InputCheatList.Invincibility,
            InputCheatList.StartAtLevelTwo,
        };
        cheatProgress = new int[cheatList.Count];
        inputDetection = InputEventHandler.Instance;
    }

    private void OnEnable()
    {
        inputDetection.OnSwipeUp += CaptureSwipeUp;
        inputDetection.OnSwipeRight += CaptureSwipeRight;
        inputDetection.OnSwipeDown += CaptureSwipeDown;
        inputDetection.OnSwipeLeft += CaptureSwipeLeft;
    }
    private void OnDisable()
    {
        inputDetection.OnSwipeUp -= CaptureSwipeUp;
        inputDetection.OnSwipeRight -= CaptureSwipeRight;
        inputDetection.OnSwipeDown -= CaptureSwipeDown;
        inputDetection.OnSwipeLeft -= CaptureSwipeLeft;
    }

    private void CaptureSwipeUp() => SetCheatProgress(Inputs.UP);
        
    private void CaptureSwipeRight() => SetCheatProgress(Inputs.RIGHT);
    
    private void CaptureSwipeDown() => SetCheatProgress(Inputs.DOWN);
    
    private void CaptureSwipeLeft() => SetCheatProgress(Inputs.LEFT);

    private void SetCheatProgress(Inputs input)
    {
        for (int i = 0; i < cheatList.Count; i++)
        {
            if (input != cheatList[i][cheatProgress[i]])
            {
                cheatProgress[i] = 0;
            }
            if (input == cheatList[i][cheatProgress[i]])
            {
                cheatProgress[i]++;
                if (cheatProgress[i] == cheatList[i].Count)
                {
                    InvokeCheat(i);
                }
            }
            
        }
        
    }

    private void InvokeCheat(int cheatIndex)
    {
        switch (cheatIndex)
        {
            case 0:
                Invincibility();
                break;
            case 1:
                StartAtLevelTwo();
                break;
            default:
                return;
        }
    }

    //TODO
    private void StartAtLevelTwo()
    {
        throw new System.NotImplementedException();
    }

    private void Invincibility()
    {
        throw new System.NotImplementedException();
    }
}

internal enum Inputs
{
    UP,
    RIGHT,
    DOWN,
    LEFT
};
internal static class InputCheatList
{
    internal static List<Inputs> StartAtLevelTwo = new List<Inputs>()
    {
        Inputs.UP,
        Inputs.LEFT,
        Inputs.DOWN,
        Inputs.UP,
        Inputs.DOWN,
        Inputs.RIGHT,
        Inputs.DOWN,
        Inputs.DOWN
    };

    internal static List<Inputs> Invincibility = new List<Inputs>()
    {
        Inputs.UP,
        Inputs.UP,
        Inputs.DOWN, 
        Inputs.DOWN, 
        Inputs.LEFT, 
        Inputs.RIGHT,
        Inputs.LEFT,
        Inputs.RIGHT,
    };
}

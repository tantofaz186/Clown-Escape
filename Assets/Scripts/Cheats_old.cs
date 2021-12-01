using System.Collections.Generic;
using Controllers;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cheats_Old : MonoBehaviour
{
    private InputEventHandler inputDetection;
    private UIController uiController;
    private List<List<Inputs>> cheatList;
    [SerializeField]private int[] cheatProgress;
    private void Awake()
    {
        uiController = UIController.Instance;
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
        SceneManager.sceneUnloaded += SceneManagerOnsceneUnloaded;
    }

    private void OnDisable()
    {
        inputDetection.OnSwipeUp -= CaptureSwipeUp;
        inputDetection.OnSwipeRight -= CaptureSwipeRight;
        inputDetection.OnSwipeDown -= CaptureSwipeDown;
        inputDetection.OnSwipeLeft -= CaptureSwipeLeft;
        SceneManager.sceneUnloaded -= SceneManagerOnsceneUnloaded;
    }

    private void CaptureSwipeUp() => SetCheatProgress(Inputs.UP);
        
    private void CaptureSwipeRight() => SetCheatProgress(Inputs.RIGHT);
    
    private void CaptureSwipeDown() => SetCheatProgress(Inputs.DOWN);
    
    private void CaptureSwipeLeft() => SetCheatProgress(Inputs.LEFT);

    private void SetCheatProgress(Inputs input)
    {
        Debug.Log($"Cheat progress input: {input} ");
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
                    cheatProgress[i] = 0;
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
                UnlockLevelSelectScreen();
                break;
            default:
                return;
        }
    }

    private void SceneManagerOnsceneUnloaded(Scene arg0)
    {
        ResetCheats();
    }

    private void ResetCheats()
    {
        GameOverOnCollision.playerIsInvincible = false;
    }
    private void UnlockLevelSelectScreen()
    {
        uiController.LevelSelect();
    }
    private void Invincibility()
    {
        Debug.Log("Invincibility");
        GameOverOnCollision.playerIsInvincible = true;
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

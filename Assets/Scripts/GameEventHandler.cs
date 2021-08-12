using System;
using UnityEngine;

public class GameEventHandler : MonoBehaviour
{
    #region Event Subscription

    private void OnEnable()
    {
        Enemy.CollidedWithCharacter += GameOver;

    }

    private void OnDisable()
    {
        Enemy.CollidedWithCharacter -= GameOver;

    }

    #endregion

    private void GameOver()
    {
        throw new NotImplementedException();
    }
}

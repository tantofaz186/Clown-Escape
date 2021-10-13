using System;
using UnityEngine;

namespace Controllers
{
    public class GameEventHandler : MonoBehaviour
    {
        [SerializeField]private FinishLine LevelFinishLine;
        #region Event Subscription

        private void OnEnable()
        {
            Enemy.CollidedWithCharacter += GameOver;
            LevelFinishLine.OnFinish += GameWin;
        }

        private void OnDisable()
        {
            Enemy.CollidedWithCharacter -= GameOver;
            LevelFinishLine.OnFinish -= GameWin;
        }

        #endregion

        private void GameOver()
        {
            throw new NotImplementedException();
        }
        private void GameWin()
        {
            throw new NotImplementedException();
        }
    }
}

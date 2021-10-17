using System;
using UnityEngine;

namespace Controllers
{
    public class GameEventHandler : Singleton<GameEventHandler>
    {
        [SerializeField]private FinishLine LevelFinishLine;
        private UIController m_UIController;
        private void Awake()
        {
            m_UIController = UIController.Instance;
        }

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
            m_UIController.GameOver();
        }
        private void GameWin()
        {
            m_UIController.GameWin();
        }
    }
}

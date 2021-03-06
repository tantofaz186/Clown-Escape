using UnityEngine;

namespace Controllers
{
    public class GameEventHandler : Singleton<GameEventHandler>
    {
        [SerializeField]private FinishLine LevelFinishLine;
        private UIController m_UIController;
        private ScoreTracker scoreTracker;
        private void Awake()
        {
            scoreTracker = ScoreTracker.Instance;
            m_UIController = UIController.Instance;
        }

        #region Event Subscription

        private void OnEnable()
        {
            GameOverOnCollision.CollidedWithCharacter += GameOver;
            LevelFinishLine.OnFinish += GameWin;
        }

        private void OnDisable()
        {
            GameOverOnCollision.CollidedWithCharacter -= GameOver;
            LevelFinishLine.OnFinish -= GameWin;
        }

        #endregion

        private void GameOver()
        {
            m_UIController.GameOver();
            scoreTracker.Restart();
            scoreTracker.DisplayScore();
        }
        private void GameWin()
        {
            m_UIController.GameWin();
            scoreTracker.SaveScore();
            scoreTracker.DisplayScore();
        }
    }
}

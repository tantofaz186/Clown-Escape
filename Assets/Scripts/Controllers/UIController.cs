using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Controllers
{
    public class UIController : Singleton<UIController>
    {
        [SerializeField] private GameObject MainMenuScreen;
        [SerializeField] private GameObject GameWinScreen;
        [SerializeField] private GameObject GameOverScreen;

        private void OnEnable()
        {
            SceneManager.sceneLoaded += SceneManagerOnsceneLoaded;
            SceneManager.sceneUnloaded += SceneManagerOnsceneUnloaded;
        }

        private void OnDisable()
        {
            SceneManager.sceneLoaded -= SceneManagerOnsceneLoaded;
            SceneManager.sceneUnloaded -= SceneManagerOnsceneUnloaded;
        }

        public void StartGame()
        {
            if (SceneManager.GetSceneByBuildIndex(1).isLoaded)
            {
                SceneManager.sceneUnloaded += WaitUntilLevelIsLoaded;
                SceneManager.UnloadSceneAsync(1);
            }
            else
            {
                SceneManager.LoadSceneAsync(1);
            }
        }

        private void WaitUntilLevelIsLoaded(Scene unloadedScene)
        {
            SceneManager.sceneUnloaded -= WaitUntilLevelIsLoaded;
            SceneManager.LoadSceneAsync(unloadedScene.buildIndex);
        }


        public void QuitGame()
        {
            Application.Quit();
        }

        private void DisableAllScreens()
        {
            GameWinScreen.SetActive(false);
            GameOverScreen.SetActive(false);
            MainMenuScreen.SetActive(false);
        }

        public void GameWin()
        {
            DisableAllScreens();
            GameWinScreen.SetActive(true);
        }

        public void GameOver()
        {
            DisableAllScreens();
            GameOverScreen.SetActive(true);
        }

        public void MainMenu()
        {
            DisableAllScreens();
            MainMenuScreen.SetActive(true);
        }

        private void SceneManagerOnsceneLoaded(Scene loadedScene, LoadSceneMode mode)
        {
            SceneManager.SetActiveScene(loadedScene);
        }

        private void SceneManagerOnsceneUnloaded(Scene unloadedScene)
        {
            
        }
    }
}
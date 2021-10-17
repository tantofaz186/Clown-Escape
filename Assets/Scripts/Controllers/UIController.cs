using System;
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
            DisableAllScreens();
            if (SceneManager.GetSceneByBuildIndex(1).isLoaded)
            {
                SceneManager.sceneUnloaded += WaitUntilLevelIsUnloaded;
                SceneManager.UnloadSceneAsync(1);
            }
            else
            {
                SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
            }
        }

        private void WaitUntilLevelIsUnloaded(Scene unloadedScene)
        {
            SceneManager.sceneUnloaded -= WaitUntilLevelIsUnloaded;
            SceneManager.LoadSceneAsync(unloadedScene.buildIndex, LoadSceneMode.Additive);
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
            SceneManager.UnloadSceneAsync(1);
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
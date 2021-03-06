using UnityEngine;
using UnityEngine.SceneManagement;

namespace Controllers
{
    public class UIController : Singleton<UIController>
    {
        private AudioManager audioManager;
        [SerializeField] private GameObject MainMenuScreen;
        [SerializeField] private GameObject GameWinScreen;
        [SerializeField] private GameObject GameOverScreen;
        [SerializeField] private GameObject TutorialScreen;
        [SerializeField] private GameObject SettingsScreen;
        [SerializeField] private GameObject LevelSelectScreen;
        private int lastLoadedSceneIndex;

        private void Awake()
        {
            audioManager = AudioManager.Instance;
        }

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

        public void StartGame(int sceneIndex = 1)
        {
            UnloadPreviousScenes();
            if (sceneIndex == 0)
            {
                SceneManager.LoadSceneAsync(lastLoadedSceneIndex, LoadSceneMode.Additive);
            }
            else if (SceneManager.GetSceneByBuildIndex(sceneIndex).isLoaded)
            {
                SceneManager.sceneUnloaded += WaitUntilLevelIsUnloaded;
                SceneManager.UnloadSceneAsync(sceneIndex);
            }
            else
            {
                SceneManager.LoadSceneAsync(sceneIndex, LoadSceneMode.Additive);
            }
            DisableAllScreens();
        }

        private void UnloadPreviousScenes()
        {
            for (int i = 1; i < SceneManager.sceneCountInBuildSettings; i++)
            {
                if(SceneManager.GetSceneByBuildIndex(i).isLoaded)
                {
                    SceneManager.UnloadSceneAsync(i);
                }
            }
        }

        public void QuitGame()
        {
            Application.Quit();
        }

        public void GameWin()
        {
            SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
            DisableAllScreens();
            GameWinScreen.SetActive(true);
        }

        public void GameOver()
        {
            SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
            DisableAllScreens();
            GameOverScreen.SetActive(true);
        }

        private void DisableAllScreens()
        {
            GameWinScreen.SetActive(false);
            GameOverScreen.SetActive(false);
            MainMenuScreen.SetActive(false);
            TutorialScreen.SetActive(false);
            SettingsScreen.SetActive(false);
            LevelSelectScreen.SetActive(false);
        }

        public void MainMenu()
        {
            if (SceneManager.GetSceneByBuildIndex(1).isLoaded) SceneManager.UnloadSceneAsync(1);
            DisableAllScreens();
            MainMenuScreen.SetActive(true);
        }

        public void TutorialMenu()
        {
            DisableAllScreens();
            TutorialScreen.SetActive(true);
        }

        public void SettingsMenu()
        {
            DisableAllScreens();
            SettingsScreen.SetActive(true);
        }

        public void LevelSelect()
        {
            DisableAllScreens();
            LevelSelectScreen.SetActive(true);
        }

        private void WaitUntilLevelIsUnloaded(Scene unloadedScene)
        {
            SceneManager.sceneUnloaded -= WaitUntilLevelIsUnloaded;
            SceneManager.LoadSceneAsync(unloadedScene.buildIndex, LoadSceneMode.Additive);
        }

        private void SceneManagerOnsceneLoaded(Scene loadedScene, LoadSceneMode mode)
        {
            SceneManager.SetActiveScene(loadedScene);
        }

        private void SceneManagerOnsceneUnloaded(Scene unloadedScene)
        {
            lastLoadedSceneIndex = unloadedScene.buildIndex;
        }
    }
}
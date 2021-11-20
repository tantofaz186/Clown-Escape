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
            DisableAllScreens();
            if (SceneManager.GetSceneByBuildIndex(sceneIndex).isLoaded)
            {
                SceneManager.sceneUnloaded += WaitUntilLevelIsUnloaded;
                SceneManager.UnloadSceneAsync(sceneIndex);
            }
            else
            {
                SceneManager.LoadSceneAsync(sceneIndex, LoadSceneMode.Additive);
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
        }
        public void MainMenu()
        {
            if(SceneManager.GetSceneByBuildIndex(1).isLoaded) SceneManager.UnloadSceneAsync(1);
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
            
        }
    }
}
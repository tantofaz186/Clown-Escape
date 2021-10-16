using UnityEngine;
using UnityEngine.SceneManagement;

namespace Controllers
{
    public class UIController : MonoBehaviour
    {
        
        public void StartGame()
        {
            SceneManager.LoadScene(1);
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}

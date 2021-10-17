using UnityEngine;
using UnityEngine.SceneManagement;

namespace Controllers
{
    public class UICamera : MonoBehaviour
    {
        private Camera m_Camera;
        private AudioListener listener;

        private void Awake()
        {
            m_Camera = GetComponent<Camera>();
            listener = GetComponent<AudioListener>();
        }

        private void OnEnable()
        {
            SceneManager.activeSceneChanged += DisableComponents;
        }
        private void OnDisable()
        {
            SceneManager.activeSceneChanged -= DisableComponents;
        }
        private void DisableComponents(Scene oldScene, Scene newScene)
        {
            m_Camera.enabled = listener.enabled = newScene == gameObject.scene;
        }
    }
}

using UnityEngine;

namespace Controllers
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioManager : Singleton<AudioManager>
    {
        public AudioSource audioSource;
        public AudioSource musicSource;

        private void Awake()
        {
            if (audioSource == null)
                audioSource = GetComponent<AudioSource>();
            if (PlayerPrefs.HasKey("Volume"))
            {
                audioSource.volume = PlayerPrefs.GetFloat("Volume");
                musicSource.volume = PlayerPrefs.GetFloat("Volume");
            }
        }
    }
}

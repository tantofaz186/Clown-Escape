using System;
using UnityEngine;
using UnityEngine.UI;

namespace Controllers
{
    public class SliderValueOnAwake : MonoBehaviour
    {
        [SerializeField] private string playerPrefsKeyName;
        private void Awake()
        {
            if(playerPrefsKeyName == null)
                Debug.LogError($"Slider Key not set on object {gameObject.name}");
            try
            {
                GetComponent<Slider>().value = PlayerPrefs.GetFloat(playerPrefsKeyName);
            }
            catch
            {
                Debug.LogWarning($"<color=red>Key {playerPrefsKeyName} not found in PlayerPrefs</color>");
            }
        }
    }
}

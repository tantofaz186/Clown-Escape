using System;
using UnityEngine;
using UnityEngine.UI;

namespace Controllers
{
    public class SliderController : MonoBehaviour
    {
        [SerializeField] private string playerPrefsKeyName;
        private Slider m_Slider;
        private void Awake()
        {
            m_Slider = GetComponent<Slider>();
            if(playerPrefsKeyName == null)
                Debug.LogError($"Slider Key not set on object {gameObject.name}");
            try
            {
                m_Slider.value = PlayerPrefs.GetFloat(playerPrefsKeyName);
            }
            catch
            {
                Debug.LogWarning($"<color=red>Key {playerPrefsKeyName} not found in PlayerPrefs</color>");
            }
        }
        public void OnSliderValueChanged()
        {
            PlayerPrefs.SetFloat("Volume", m_Slider.value);
            PlayerPrefs.Save();
        }
    }
}

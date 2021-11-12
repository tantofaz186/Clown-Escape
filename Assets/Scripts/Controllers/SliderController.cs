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
                m_Slider.value = PlayerPrefs.HasKey(playerPrefsKeyName)? PlayerPrefs.GetFloat(playerPrefsKeyName): 1;
            }
            catch
            {
                Debug.LogWarning($"<color=red>Key {playerPrefsKeyName} not found in PlayerPrefs</color>");
                m_Slider.value = 1;
            }
        }
        public void OnSliderValueChanged()
        {
            PlayerPrefs.SetFloat(playerPrefsKeyName, m_Slider.value);
            PlayerPrefs.Save();
        }
    }
}

using System;
using Controllers;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreTracker : Singleton<ScoreTracker>
{
    private float bestScore;
    private float score;
    [SerializeField] private TextMeshProUGUI currentScoreText;
    [SerializeField] private TextMeshProUGUI bestScoreText;
    
    string playerPrefsKey;
    
    private void Awake()
    {
        ResetToDefault();
    }

    void Update()
    {
        score += Time.deltaTime;
    }

    private void ResetToDefault()
    {
        playerPrefsKey = $"{SceneManager.GetActiveScene().name}_score";
        if (!PlayerPrefs.HasKey(playerPrefsKey))
        {
            PlayerPrefs.SetFloat(playerPrefsKey, 0);
        }
        bestScore = PlayerPrefs.GetFloat(playerPrefsKey);
        Restart();
    }

    public void Restart()
    {
        score = 0;
    }
    
    public void SaveScore()
    {
        PlayerPrefs.SetFloat(playerPrefsKey, score);
    }
    public void DisplayScore()
    {
        var bestTime = TimeSpan.FromSeconds(PlayerPrefs.GetFloat(playerPrefsKey));
        var currentTime = TimeSpan.FromSeconds(score);
        bestScoreText.text = bestTime.ToString(@"mm\:ss\:fff");
        currentScoreText.text = currentTime.ToString(@"mm\:ss\:fff");;
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += SceneManagerOnsceneLoaded;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= SceneManagerOnsceneLoaded;
    }
    private void SceneManagerOnsceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        ResetToDefault();
    }
}

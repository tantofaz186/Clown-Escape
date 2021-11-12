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
    
    string playerPrefsKey => $"{SceneManager.GetActiveScene().name}_score";
    
    private void Awake()
    {
        var scoreKey = playerPrefsKey;
        if (!PlayerPrefs.HasKey(scoreKey))
        {
            PlayerPrefs.SetFloat(scoreKey, 0);
        }
        bestScore = PlayerPrefs.GetFloat(scoreKey);
    }
    void Start()
    {
        Restart();
    }
    
    void Update()
    {
        score += Time.deltaTime;
    }
    
    public void Restart()
    {
        score = 0;
    }
    
    public void SaveScore()
    {
        PlayerPrefs.SetFloat(playerPrefsKey, Mathf.Min(score, bestScore));
    }
    public void DisplayScore()
    {
        var bestTime = TimeSpan.FromSeconds(bestScore);
        var currentTime = TimeSpan.FromSeconds(score);
        bestScoreText.text = bestTime.ToString(@"mm\:ss\:fff");
        currentScoreText.text = currentTime.ToString(@"mm\:ss\:fff");;
    }
}

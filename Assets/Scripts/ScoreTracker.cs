using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreTracker : MonoBehaviour
{
    private float bestScore;
    private float score;

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

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
    }

    private void OnEnable()
    {
        GameOverOnCollision.CollidedWithCharacter += StopScoreCount;
    }

    private void OnDisable()
    {
        GameOverOnCollision.CollidedWithCharacter -= StopScoreCount;
    }

    void StopScoreCount()
    {
        
    }
}

using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;  
    private int score = 0;

    [SerializeField] GameObject Player;
    [SerializeField] GameObject point;

    void Start()
    {
        UpdateScoreText();  
    }

    void Update()
    {
        if (Vector3.Distance(point.transform.position, Player.transform.position) < 0.5)
        {
            AddScore(10);
            UpdateScoreText();
        }
    }

    public void AddScore(int points)
    {
        score += points; 
        UpdateScoreText();  
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score; 
    }
}
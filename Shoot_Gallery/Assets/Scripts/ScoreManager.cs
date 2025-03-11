using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance; // Singleton para facilitar o acesso

    public static int score = 0;
    public Text scoreText; // Referência ao texto da UI que exibirá a pontuação
    public Text scoreMenuText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreUI();
    }

    public void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
            scoreMenuText.text = "Score: " + score;
        }
    }

}
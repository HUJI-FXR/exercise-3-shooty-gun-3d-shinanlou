using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreScript : MonoBehaviour
{
    private TextMeshProUGUI highScoreText;
    private int highScore;

    [SerializeField] private Scorescriptmanager scoreScript;

    void Start()
    {
        highScoreText = GetComponent<TextMeshProUGUI>();

        // Load high score from PlayerPrefs
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            highScore = 0;
        }

        // Update the high score display at the start
        UpdateHighScore();
    }

    // Method to update the high score display
    void UpdateHighScore()
    {
        if (highScoreText != null)
        {
            highScoreText.text = "High Score: " + highScore.ToString();
        }
    }

    // Method to check and update the high score if necessary
    public void CheckAndUpdateHighScore()
    {
        // If the current score is higher than the stored high score
        if (scoreScript.GetScore() > highScore)
        {
            highScore = Mathf.FloorToInt(scoreScript.GetScore());
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
            UpdateHighScore();
        }
    }
}

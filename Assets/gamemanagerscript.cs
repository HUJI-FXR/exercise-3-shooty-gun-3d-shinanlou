using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI gameOverText;
    [SerializeField] private GameObject player;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private HighScoreScript highScoreScript; // Add this line to reference the HighScoreScript

    private bool isGameOver = false;

    void Start()
    {
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(false);
        }
    }

    public void GameOver()
    {
        if (isGameOver) return;

        isGameOver = true;

        // Check and update the high score when the game ends
        highScoreScript.CheckAndUpdateHighScore();

        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(true);
            gameOverText.text = "Game Over!";
        }

        Time.timeScale = 0;

        if (mainCamera != null)
        {
            mainCamera.gameObject.SetActive(true);
            mainCamera.transform.SetParent(null);
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        isGameOver = false;

        if (player != null)
        {
            Destroy(player);
        }
    }
}

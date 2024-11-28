using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // Make sure this line is included to reference TextMesh Pro components

public class Scorescriptmanager : MonoBehaviour
{
    private TextMeshProUGUI scoretext;  // Reference to the TextMeshProUGUI component
    private float score = 0f;  // Initialize score to 0
    [SerializeField] private float comboBonus = 5f;  // Bonus points based on combo
    [SerializeField] private float comboTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        // Get the TextMeshProUGUI component attached to the GameObject
        scoretext = GetComponent<TextMeshProUGUI>();

        // Update the score display at the start
        UpdateScoreBar();
    }

    // Update is called once per frame
    void Update()
    {
        // Continuously update the score display
        UpdateScoreBar();
        comboTimer += Time.deltaTime;

    }

    // Method to update the score display
    void UpdateScoreBar()
    {
        if (scoretext != null)
        {
            scoretext.text = "Score: " + score.ToString();  // Display the score
        }
    }

    public void ResetComboTimer()
    {
        comboTimer = 0f;  
    }

    public void AddScore()
    {
        // חישוב הציון לפי הזמן שעבר
        float points = 1f + (comboBonus / comboTimer);
        score += Mathf.FloorToInt(points);  // הוספת הנקודות לציון
        comboTimer = 0f;  // איפוס טיימר הקומבו
        UpdateScoreBar();  // עדכון תצוגת הנקודות
    }

    public float GetScore()
    {
        return score;
    }
    
}

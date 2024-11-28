using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;  // Make sure to include this for TextMeshPro

public class LifeBarScript : MonoBehaviour
{
    [SerializeField] private LifeTotalScript playerLife;  // Reference to the player's LifeTotalScript
    private TextMeshProUGUI lifetext;  // Text component to display life

    // Start is called before the first frame update
    void Start()
    {
        // Get the TextMeshProUGUI component attached to the GameObject
        lifetext = GetComponent<TextMeshProUGUI>();

        // Update the life bar at the start
        UpdateLifeBar();
    }

    // Update is called once per frame
    void Update()
    {
        // Continuously update the life bar to show the current life
        UpdateLifeBar();
    }

    // Update the text to reflect the current life total
    void UpdateLifeBar()
    {
        // Set the TextMeshProUGUI component's text to show the life
        if (lifetext != null && playerLife != null)
        {
            lifetext.text = "HP: " + playerLife.lifeTotal.ToString();
        }
    }
}
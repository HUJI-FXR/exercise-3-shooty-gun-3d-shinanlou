using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTotalScript : MonoBehaviour
{
    [SerializeField] public float initialLifeTotal;
    public float lifeTotal;
    [SerializeField] private Scorescriptmanager scoreScript;

    void Start()
    {
        lifeTotal = initialLifeTotal;
    }

    void Update()
    {
        if (lifeTotal <= 0)
        {
            if (gameObject.CompareTag("monster"))
            {
                if (scoreScript != null)
                {
                    scoreScript.AddScore();
                }
            }

            if (gameObject.CompareTag("player"))
            {
                GameManager gameManager = FindObjectOfType<GameManager>();
                if (gameManager != null)
                {
                    gameManager.GameOver();
                }
            }

            Destroy(gameObject);
        }
    }

    public void TakeDamage(float damageAmount)
    {
        lifeTotal -= damageAmount;
    }

    public void AddLife(float lifeAmount)
    {
        lifeTotal += lifeAmount;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTotalScript : MonoBehaviour
{
    [SerializeField] public float initialLifeTotal;
    public float lifeTotal;
    [SerializeField] private ScoreScript scoreScript; 
    // Start is called before the first frame update
    void Start()
    {
        lifeTotal = initialLifeTotal;
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeTotal <= 0)
        {
            if (gameObject.CompareTag("monster"))  // @@@ בדיקה אם מדובר במפלצת
            {
                if (scoreScript != null)  // @@@ קריאה לפונקציה AddScore מתוך ScoreScript
                {
                    scoreScript.AddScore();  // @@@ הוספת נקודות על הרג המפלצת
                }
            }
            Destroy(gameObject);
        }
    }
}

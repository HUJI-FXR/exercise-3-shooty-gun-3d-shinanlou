using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    [SerializeField] private float minDamage;
    [SerializeField] private float maxDamage;

    void Start() { }

    void Update() { }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player") && !gameObject.CompareTag("bullet"))
        {
            collision.gameObject.GetComponent<LifeTotalScript>().lifeTotal -= Random.Range(minDamage, maxDamage);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("monster") && !gameObject.CompareTag("monster"))
        {
            collision.gameObject.GetComponent<LifeTotalScript>().lifeTotal -= Random.Range(minDamage, maxDamage);
            Destroy(gameObject);

            GameObject player = GameObject.FindGameObjectWithTag("player");
            if (player != null)
            {
                Scorescriptmanager scoreScript = player.GetComponent<Scorescriptmanager>();
                if (scoreScript != null)
                {
                    scoreScript.AddScore();
                    scoreScript.ResetComboTimer();
                }
            }
        }
    }
}

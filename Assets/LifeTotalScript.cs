using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTotalScript : MonoBehaviour
{
    [SerializeField] public float initialLifeTotal;
    public float lifeTotal;
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
            Destroy(gameObject);
        }
    }
}

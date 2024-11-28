using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpwanerScript : MonoBehaviour
{
    [SerializeField] private int numOfMonsters;
    [SerializeField] public GameObject monster;
    // Start is called before the first frame update
    void Start()
    {
        for (int i= 0; i < numOfMonsters; i++)
        {
            float x = Random.Range(0, 100);
            float z = Random.Range(0, 70);
            Vector3 pos = new Vector3(x, monster.transform.position.y, z);
            Quaternion rotationInit = Quaternion.identity;
            GameObject newMonster = Instantiate(monster, pos, rotationInit);
            newMonster.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

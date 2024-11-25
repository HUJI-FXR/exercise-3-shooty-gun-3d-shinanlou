using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterControlScript : MonoBehaviour
{
    public MovementScript movementscript;
    private float movespeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        movementscript = GetComponent<MovementScript>();
    }

    // Update is called once per frame
    void Update()
    {
        movementscript.moveforward(movespeed);
    }
  
}

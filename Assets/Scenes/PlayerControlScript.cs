using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlScript : MonoBehaviour
{
    [SerializeField] private MovementScript movementscript;
    private float curYrotation;

    // Start is called before the first frame update
    void Start()
    {
        movementscript = GetComponent<MovementScript>();
    }

    // Update is called once per frame
    void Update()
    {
        curYrotation = transform.eulerAngles.y; 

        if (Input.GetKey(KeyCode.W)){
            movementscript.moveforward(curYrotation);
        }
        if(Input.GetKey(KeyCode.Space)){
            movementscript.Jump();
        }
    }
}

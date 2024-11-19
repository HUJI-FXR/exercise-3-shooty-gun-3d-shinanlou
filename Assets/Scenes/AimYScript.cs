using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float y;           // Vertical rotation
    [SerializeField] private float sensitivity = 100f;  // Sensitivity for mouse movement
    [SerializeField] private float clampAngle = 90f; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        y += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime; // Vertical rotation
        y = Mathf.Clamp(y, -clampAngle, clampAngle); // Clamps the vertical rotation
        transform.rotation = Quaternion.Euler(-y, 0, 0);

    }
}

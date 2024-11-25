using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float y;           // Vertical rotation
    [SerializeField] private float sensitivity;  // Sensitivity for mouse movement
    [SerializeField] private float clampAngle = 90f; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        y = Mathf.Clamp(y + Input.GetAxis("Mouse Y") * sensitivity , -clampAngle, clampAngle); // Clamps the vertical rotation
        transform.rotation = Quaternion.Euler(-y, transform.rotation.eulerAngles.y, 0);

    }
}

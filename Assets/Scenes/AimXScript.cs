using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float x;           // Horizontal rotation
    [SerializeField] private float sensitivity;           // Horizontal rotation

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x += Input.GetAxis("Mouse X") * sensitivity;
        transform.rotation = Quaternion.Euler(0, x, 0);
     

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootScript : MonoBehaviour
{
    [SerializeField] private GameObject bulletprefab;
    [SerializeField] private float shootForce = 20f;   // הכוח שמופעל על הכדור

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            shoot();
        }
    }
    void shoot(){
         GameObject bullet = Instantiate(bulletprefab, transform.position, transform.rotation);
        
        // הוספת כוח לכדור כדי שהוא ינוע
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
        if (bulletRb != null)
        {
            bulletRb.AddForce(transform.forward * shootForce, ForceMode.Impulse);
        }
        // Get the Rigidbody component of the bullet
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
    }
}

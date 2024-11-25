using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public float speed = 5f;
    public float jumpforce = 10f;
    private Rigidbody rb;
    private bool istochingfloor;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    public void moveforward(float curYrotation){
        //Vector3 forwardDirection = Quaternion.Euler(0, curYrotation, 0) * Vector3.forward;
        //rb.velocity = new Vector3(forwardDirection.x * speed, rb.velocity.y, forwardDirection.z * speed);
        Vector3 forwardDirection = Quaternion.Euler(0, curYrotation, 0) * Vector3.forward;
    
        rb.velocity = new Vector3(forwardDirection.x * speed, rb.velocity.y, forwardDirection.z * speed);
    }
    public void StopMovement(){
        rb.velocity = new Vector3(0, rb.velocity.y, 0);
    }
    public void Jump(){
        if (istochingfloor){
            rb.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
        }
    }
    void OnCollisionEnter(Collision collision){
        if(collision.collider.CompareTag("Floor")){
            istochingfloor = true;
        }
    }

    void OnCollisionExit(Collision collision){
        if(collision.collider.CompareTag("Floor")){
            istochingfloor = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

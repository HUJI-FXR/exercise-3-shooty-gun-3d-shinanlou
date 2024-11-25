using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterControlScript : MonoBehaviour
{
     [SerializeField] private MovementScript movementscript;  // סקריפט התנועה של המפלצת
    [SerializeField] private bool chasePlayer = false;  // האם המפלצת רודפת אחרי השחקן
    [SerializeField] private float moveSpeed = 5f;  // מהירות תנועה של המפלצת
    [SerializeField] private Transform player;  // השחקן

    // Start is called before the first frame update
    void Start()
    {
        movementscript = GetComponent<MovementScript>();  // קישור סקריפט התנועה
        player = GameObject.FindGameObjectWithTag("Player").transform;  // למצוא את השחקן לפי תג
    }

    // // Update is called once per frame
    // void Update()
    // {
    //     // אם המפלצת צריכה לרדוף אחרי השחקן
    //     if (chasePlayer)
    //     {
    //         // חישוב כיוון השחקן ביחס למפלצת
    //         Vector3 directionToPlayer = (player.position - transform.position).normalized;
            
    //         // חישוב סיבוב של המפלצת לכיוון השחקן
    //         Quaternion targetRotation = Quaternion.LookRotation(directionToPlayer);
    //         transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * moveSpeed);
            
    //         // תנועה קדימה לכיוון השחקן
    //         movementscript.moveforward(moveSpeed);
    //     }
    //     else
    //     {
    //         // סיבוב אקראי כאשר המפלצת לא רודפת
    //         float randomRotation = Random.Range(-90f, 90f);  // חישוב סיבוב אקראי
    //         transform.Rotate(0f, randomRotation * Time.deltaTime, 0f);
            
    //         // המפלצת עדיין זזה קדימה, גם אם לא רודפת
    //         movementscript.moveforward(moveSpeed);
    //     }
    // }
    // [SerializeField] private MovementScript movementscript;
    // [SerializeField] private float monstertimer = 0f;
    // [SerializeField] private float monstertime = 3f;
    // [SerializeField] private float chasePlayerChance = 0.5f;
    // [SerializeField] private bool chasePlayer = false; 
    // [SerializeField] private float movespeed = 5f;
    // [SerializeField] private Transform player;
    // private Rigidbody rb;  

    // // Start is called before the first frame update
    // void Start()
    // {
    //     movementscript = GetComponent<MovementScript>();
    //     player = GameObject.FindGameObjectWithTag("Player").transform;
    //     rb = GetComponent<Rigidbody>();
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     monstertimer += Time.deltaTime;
    //      if (monstertimer >= monstertime)
    //     {
    //         monstertimer = 0f; 
    //         Debug.Log("Monster timer reset!");
    //         float randomValue = Random.Range(0f, 1f);
    //         if(randomValue<chasePlayerChance){
    //             chasePlayer = true;
    //         }
    //         else{
    //             chasePlayer = false;
    //         }

    //     }
        
        // if (chasePlayer)
        // {
        //     Vector3 directionToPlayer = (player.position - transform.position).normalized;
        //     directionToPlayer.y = 0f;

        //     Quaternion targetRotation = Quaternion.LookRotation(directionToPlayer);
        //     transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * movespeed);
        //     movementscript.moveforward(movespeed);
        // }
        // else
        // {
        //     transform.Rotate(0f, Random.Range(-90f, 90f) * Time.deltaTime, 0f);
        //     movementscript.moveforward(movespeed);
        // }
        // movementscript.moveforward(movespeed);
    //}
  
}

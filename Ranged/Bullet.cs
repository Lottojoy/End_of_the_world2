// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Bullet : MonoBehaviour
// {
//     public float speed;
//     private Rigidbody2D rb;
//     void Start()
//     {
//         rb = GetComponent<Rigidbody2D>();
//         rb.velocity = transform.right * speed;
//     }

//     private void OnTriggerEnter2D(Collider2D collision)
//      {
//        Aiz enemy = collision.GetComponent<Aiz>();

//        if (enemy != null)
//        {
//         enemy.TakeDamage(20);
//        } 

//        if(collision.gameObject.tag == "enemy")
//         {
//             Destroy(gameObject);
//         }
       
//     }
 
    
// }

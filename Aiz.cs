using UnityEngine;
 using System.Collections;
 using System.Collections.Generic;
 
 public class Aiz : MonoBehaviour {
     Transform target;
     public float speed = .01f;

     public Animator animator;
     public int maxHealth = 100;
     int currentHealth;
 
     
     // Use this for initialization
     void Start () 
     {
          currentHealth = maxHealth;
         
     }
     
     // Update is called once per frame
     void FixedUpdate () {
 
 
         target = GameObject.FindWithTag ("Player").transform;
 
         Vector3 forwardAxis = new Vector3 (0, 0, -1);
 
 
 
         
         transform.LookAt (target.position, forwardAxis);
         Debug.DrawLine (transform.position, target.position);
         transform.eulerAngles = new Vector3 (0, 0, -transform.eulerAngles.z);
         transform.position -= transform.TransformDirection (Vector2.up) * speed ;
     }

    void OnTriggerEnter(Collider col){

        if(col.gameObject.tag == "bullet")
        {
            currentHealth -= 20;
        }
     }

     
     
     
     
 
 
 
 
 
 }

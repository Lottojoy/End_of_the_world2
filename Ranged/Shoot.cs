using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Shoot : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;

    void Update()
    {
        if((Input.GetKeyDown(KeyCode.Space)))
        {
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
        }
    }
    
}

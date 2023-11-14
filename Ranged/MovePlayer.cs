using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovePlayer : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
       Flip(); 
    }

    void Flip()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            transform.Rotate(0, 180, 0);
        }
    }
}

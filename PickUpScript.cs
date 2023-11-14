using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    bool Pressed= false;

     void OnMouseDown()
    {
        Pressed = true;
        GetComponent<Rigidbody2D>().isKinematic = true;
    }

     void OnMouseUp()
    {
        Pressed = false;
        GetComponent<Rigidbody2D>().isKinematic = false;
    }

    void Update()
    {
        if(Pressed)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePos;
        }
    }
}

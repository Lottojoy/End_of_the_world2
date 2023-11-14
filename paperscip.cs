using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class paperscip : MonoBehaviour

{
    public AudioSource mic;
    public GameObject uiObject;
    void Start()
    {
        uiObject.SetActive(false);
    }
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            mic.Play();
            uiObject.SetActive(true);
            
        }
	}
    void OnTriggerExit2D (Collider2D player)
    {
      if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(false);
            
    
            
        }  
    }
    
}
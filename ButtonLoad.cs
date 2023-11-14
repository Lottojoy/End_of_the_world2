using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLoad : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;

    public void ButtonMoveScene(string level)
    {
        SceneManager.LoadScene(level);
    }

     

    public void LoadNextLevel()
    {
        //SceneManager.LoadScene("No game");
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));

    }

     IEnumerator  LoadLevel(int levelIndex)
     {
         transition.SetTrigger("start");
         yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
     }
}

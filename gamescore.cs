using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamescore : MonoBehaviour
{
    public float JumpForce;
    float score;

    [SerializeField]
    bool isGrounded = false;
    bool isAlive = true;

    Rigidbody2D RB;

    public Text scoreTxt;

    private void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
        score = 0;
    }

 void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space))
      {
        if(isGrounded == true)
        {
            RB.AddForce(Vector2.up * JumpForce);
            isGrounded = false;
        }
      }  

      if(isAlive)
      {
        score += Time.deltaTime * 4;
        scoreTxt.text = "RUN!! : " + score.ToString("F");
      }

      if(score == 50)
      {
         SceneManager.LoadScene("Story");
      }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            if(isGrounded == false)
            {
                isGrounded = true;
            }
        }
        if(collision.gameObject.CompareTag("spike"))
        {
            Destroy(gameObject);
            
        }
    }

}

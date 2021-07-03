using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TapControl : MonoBehaviour
{
    //public GameObject gameOvertext;
    public float tapForce = 200f;
    public float downFall = 5f;
    //public GameObject startPosition;
    int score;
    public Text scoreText;

    Rigidbody2D rb;
    Quaternion downRotation;
    Quaternion forwardRotation;

    void Start()
    {
        score = 0;
        rb = this.GetComponent<Rigidbody2D>();
        downRotation = Quaternion.Euler(0, 0, -90);
        forwardRotation = Quaternion.Euler(0, 0, 32);
            }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0)&&gameObject.CompareTag("Player"))
        {
            
            transform.rotation = forwardRotation;
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector2.up * tapForce, ForceMode2D.Force);

        }
        if (gameObject.CompareTag("Player"))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, downFall * Time.deltaTime);
        }
        
        


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("working");
        if (col.gameObject.tag == "deadboi")
        {//count as death
            rb.simulated = false;
            SceneManager.LoadScene("Scenes/gameOver");
            
        }
        if (col.gameObject.tag == "scoreboi")
        {//count a score
            Debug.Log(score.ToString());

            score++;
            scoreText.text = "Score:" + score.ToString();

        }
    }
    
   
}

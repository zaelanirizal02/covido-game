using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// using UnityEngine.Canvas;


public class Checkpoint : MonoBehaviour
{
    public float score;
    public Text ScoreUI;
   
    // Start is called before the first frame update
    void Start()
    {
        // ScoreUI.text = "Score : 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("virus"))
        {
            score ++;
            ScoreUI.text = "Score : " + score.ToString();
            Destroy(collision.collider.gameObject);

            if(score>2)
            {
                SceneManager.LoadScene("2");
            }
        }
    }

    // private void OnTriggerEnter(Collider collision)
    // {
    //     if (collision.gameObject.CompareTag("virus"))
    //     {
    //         // Destroy(collision.collider.gameObject);
    //         AddScore();
           
    //     }
    // }


    // void AddScore()
    // {
    //     score++;
    //     ScoreUI.text = "Score : " + score.ToString();
        
    // }

   
}

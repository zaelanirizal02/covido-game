using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeSet : MonoBehaviour
{   
  //timer
    public Text TextTimer;
    public float Waktu;
    public bool GameAktif = true;

    //skor
    public float score;
    public Text ScoreUI;
  
  void SetText()
  {
    int Menit = Mathf.FloorToInt(Waktu / 60);
    int Detik = Mathf.FloorToInt(Waktu % 60);
    TextTimer.text = Menit.ToString("00") + ":" + Detik.ToString("00");
  }

  float s;

  private void Update()
  {
    if (GameAktif)
     {
        SetText();

        s += Time.deltaTime;
        if (s >= 1)
        {
            Waktu--;
            s = 0;
        }
    }

    // if (GameAktif = true && score >=2)
    {
        // Debug.Log("Game Kalah");
        // GameAktif = false;
        // SceneManager.LoadScene("main");
        
    }

     if (GameAktif && Waktu <= 0 )
    {
        // Debug.Log("Game Kalah");
        GameAktif = false;
        // Time.timeScale = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
       if (GameAktif && score >= 20 )
    {
        // Debug.Log("Game Kalah");
        GameAktif = false;
        // Time.timeScale = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
  

    // SceneManager = FindObjectOfType<Checkpoint>();
    // SceneManager.LoadScene();  
  }

  private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("virus"))
        {
            score ++;
            ScoreUI.text = "Score : " + score.ToString();
            Destroy(collision.collider.gameObject);

            // if(score>2)
            // {
            //     // SceneManager.LoadScene("2");
            //     Time.timeScale = 0;
            // }
        }

        // if(score>2)
        // {
        //     GameAktif = false;
        // }
    }
}

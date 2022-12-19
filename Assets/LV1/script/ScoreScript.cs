using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.Canvas;


public class ScoreScript : MonoBehaviour
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

    // private void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.collider.CompareTag("virus"))
    //     {
    //         score ++;
    //         ScoreUI.text = "Score : " + score.ToString();
    //         Destroy(collision.collider.gameObject);
    //     }
    // }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("pelanggar"))
        {
            // Destroy(collision.collider.gameObject);
            AddScore();
        }
    }

    void AddScore()
    {
        score++;
        ScoreUI.text = "Score : " + score.ToString();
        

        // Text newtext = Instantiate(ScoreUI, transform.position, transform.rotation) as Text;
      
        // newtext.transform.SetParent(GameObject.FindGameObjectWithTag ("Canvas").transform, false);
        
        Text tempTextBox = Instantiate(ScoreUI, transform.position, transform.rotation) as Text;
                 //Parent to the panel
                  tempTextBox.transform.SetParent(GameObject.Find("Canvas").transform, false);
                  //Set the text box's text element font size and style:
                   
                   //Set the text box's text element to the current textToDisplay:
                   

         //Display UI
       // ScoreUI = GameObject.FindGameObjectWithTag ("Canvas").GetComponent<Canvas>();
       //  _text = Instantiate (_textPrefab, new Vector3 (0, 0, 0f), Quaternion.identity) as Text;
       //  _text.text = _points.ToString ();
       //  _text.transform.SetParent (_canvas.transform);

        //  Text tempTextBox = Instantiate(ScoreUI, new Vector3(0, 0, 0f), Quaternion.identity) as Text;
        // tempTextBox.transform.SetParent(Canvas.transform, false);
        
        //  // find canvas
        // GameObject canvas = GameObject.FindGameObjectWithTag ("Canvas").GetComponent<Canvas>();
        // // clone your prefab
        // GameObject text = Instantiate(text, new Vector3(0, 0, 0f), Quaternion.identity);
        // // set canvas as parent to the text
        // text.transform.SetParent(canvas.transform);
    }

   
}

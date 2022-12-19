using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport1 : MonoBehaviour


{
    public int LevelIndex;
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "APD")
        {
        	SceneManager.LoadScene(LevelIndex);
        }
    }
}

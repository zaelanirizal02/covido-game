using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class replace : MonoBehaviour
{
 
     private GameObject Grain1;
     private GameObject Grain2;
     private GameObject Grain3;
     private GameObject Grain4;
 
     private float time;
 
 
     void Start() {
 
         Grain1 = GameObject.FindGameObjectWithTag("Grain1");
         Grain2 = GameObject.FindGameObjectWithTag("Grain2");
         Grain3 = GameObject.FindGameObjectWithTag("Grain3");
         Grain4 = GameObject.FindGameObjectWithTag("Grain4");
 
         time = 0;
 
     }
 
 
     void Update () 
     {
         time += Time.deltaTime;
 
         if (time >= 5) {
             grow();
         }
 
     }
 
     void grow(){
                     
         Instantiate(Grain4, Grain3.transform.position, Grain3.transform.rotation);
         Instantiate(Grain3, Grain2.transform.position, Grain2.transform.rotation);
         Instantiate(Grain2, Grain1.transform.position, Grain1.transform.rotation);
 
         time = 0;
 
         }
 
 }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyNpc1 : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;


    void Update()
    {
        if ( Input.GetMouseButtonDown(0))
        {
        	ray = Camera.main.ScreenPointToRay (Input.mousePosition);

        	if (Physics.Raycast(ray, out hit, float.MaxValue))
        	{
        	   if(hit.rigidbody.CompareTag("pelanggar"))
               {
                // hit.rigidbody.gameObject.GetComponent<BoxCollider>().enable = true;
                // hit.rigidbody.gameObject.GetComponent<BoxCollider>.enable(false);
                hit.rigidbody.gameObject.SetActive(false);
               }
        	}
        }
    }

    // void Update() {
    //      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //      RaycastHit hit;
    //      if (Physics.Raycast(ray, -Vector3.up, out hit))
    //          if(hit.transform.tag == "someTag") {
    //          }
         
    //  }
}

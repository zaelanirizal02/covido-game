using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyNpc : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] private GameObject prefab;
    // Update is called once per frame
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(ray.origin, ray.direction * 20, Color.white);
            if (Physics.Raycast(ray, out hit)){
                if (hit.collider.CompareTag("pelanggar")) {
                    Destroy(hit.transform.gameObject);
                    Instantiate(prefab, hit.collider.transform.position, Quaternion.identity);
                    Debug.Log("Clicked on " + hit.transform.gameObject.name);
                    
                    // 19,94 0.18 23,62
                }
                else {
                    Debug.Log("no hit");
                }
            }
            // if (Physics.Raycast(ray, out hit))
            // {
            //     // Gets a Game Object reference from its Transform
            //     if (hit.gameObject.CompareTag("pelanggar"))
            //     {

            //         Instantiate(prefab, hit.point, Quaternion.identity);
            //         Debug.Log("My object is clicked by mouse");
            //         // hit.rigidbody.gameObject.SetActive(false);

            //     }
            // }
        }
        // if ( Input.GetMouseButtonDown(0))
        // {
        // 	RaycastHit hit;
        // 	Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);



        //  //     if (Physics.Raycast(ray, out hit))   
        //  //    {
        //  //       if(hit.collider.gameObject.tag == "pelanggar") // here i want to tag another gameobject
        //  //        {
        //  //        gameObject.tag. = ();


        //  //            // Destroy(hit.collider.GetComponent<CapsuleCollider>());
        // 	// // if (Physics.Raycast(ray, out hit))
        // 	// // {
        // 	// // 	BoxCollider bc = hit.collider as BoxCollider;
        // 	// // 	if (bc != null)
        // 	// // 	{
        // 	// // 		Destroy(bc.gameObject);
        // 	// // 	}
        // 	// // }
        //  //        }
        //  //    }
        // }
    }
}

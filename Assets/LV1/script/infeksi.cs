using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infeksi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
       
        //  if (collision.collider.CompareTag("virus"))
        // {
        //     Destroy(collision.gameObject);
        // }
         if (collision.collider.CompareTag("bossX"))
        {
            Destroy(collision.gameObject);
        }
         if (collision.collider.CompareTag("remyX"))
        {
            Destroy(collision.gameObject);
        }
         if (collision.collider.CompareTag("l"))
        {
            Destroy(collision.gameObject);
        }
         if (collision.collider.CompareTag("checkpoint"))
        {
            // Destroy(collision.gameObject);
        }
    }

    // void OnTriggerEnter(Collider other) 
    //     {
    //         if (other.gameObject.tag.Equals("hapus"))
    //         {
    //             Destroy(other.gameObject);
    //         }
    //     }
    

    
}

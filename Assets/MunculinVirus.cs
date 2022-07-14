using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculinVirus : MonoBehaviour

{
    public GameObject virus;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MunculVirus());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     //jeda munculin viirus
    IEnumerator MunculVirus()
    {  
        Instantiate(virus, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1);
        StartCoroutine(MunculVirus());
    }
}

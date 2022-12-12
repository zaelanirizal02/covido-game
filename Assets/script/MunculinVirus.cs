using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MunculinVirus : MonoBehaviour

{
    // [SerializeField] Transform[] Positions;
    // [SerializeField] float ObjectSpeed;
    

    //int NextPosIndex;
    // Transform NextPos;

    public GameObject virus;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MunculVirus());
        // NextPos = Positions[0];
    }

    // Update is called once per frame
    void Update()
    {
        // MoveGameObject();
    }

    //  jeda waktu munculin viirus
    IEnumerator MunculVirus()
    {  
        Instantiate(virus, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(10);
        StartCoroutine(MunculVirus());
    }

    // void MoveGameObject()
    // {
    //     if (transform.position == NextPos.position)
    //     {
    //         NextPosIndex++;
    //         if (NextPosIndex >= Positions.Length)
    //         {
    //             NextPosIndex = 0;
    //         }
    //         NextPos = Positions[NextPosIndex];
    //     }
    //     else
    //     {
    //         transform.position = Vector3.MoveTowards(transform.position, NextPos.position, ObjectSpeed * Time.deltaTime);
    //     }
    // }
}

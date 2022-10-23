using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MunculinNPC : MonoBehaviour

{
    public GameObject npc;
    // public int yPos;
    [SerializeField] float jeda;
  
    void Start()
    {
        StartCoroutine(MunculNPC());
        // NextPos = Positions[0];
        // RandomizeMyRotation();
    }

    // Update is called once per frame
    void Update()
    {
        // MoveGameObject();
    }

    //  jeda waktu munculin npc
    IEnumerator MunculNPC()
    {   
        // yPos = Random.Range(-90, 90);
        // Instantiate(npc, new Vector3(22, yPos, 21), Quaternion.identity);
        Instantiate(npc, transform.position,  Quaternion.identity);
        yield return new WaitForSeconds(jeda);
        StartCoroutine(MunculNPC());
    }

    // void RandomizeMyRotation()
    // {
    //     transform.rotation = Random.rotation;
    // }
    //     StartCoroutine(MunculNPC());
    // }

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject uiObject;
    public GameObject uiObjectPanel;
    void Start()
    {
        uiObject.SetActive(false);
        uiObjectPanel.SetActive(false);
    }

    // Update is called once per frame
    //memunculkan ui ketika di posisi
    void OnTriggerEnter (Collider apd)
    {
      if (apd.gameObject.tag == "APD")
      {
        uiObject.SetActive(true);
        uiObjectPanel.SetActive(true);
        StartCoroutine("WaitForSec");
      }

    }

    IEnumerator WaitForSec()
    {
      yield return new WaitForSeconds(5);
      uiObject.SetActive(false);
      uiObjectPanel.SetActive(false);

    }

}

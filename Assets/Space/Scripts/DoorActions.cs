using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorActions : MonoBehaviour
{
   [SerializeField] private Animator myDoor = null;
   [SerializeField] private bool openTrigger = false;
   [SerializeField] private bool closeTrigger = false;
   [SerializeField] private GameObject Blockade;
   private void OnTriggerEnter(Collider other)
   {
    if(openTrigger)
    {
        myDoor.Play("door_1_open", 0, 0.0f);
        gameObject.SetActive(false);
    }
    else if(closeTrigger)
    {
        myDoor.Play("door_1_close", 0, 0.0f);
        gameObject.SetActive(false);
        Blockade.SetActive(true);
    }
   }
}

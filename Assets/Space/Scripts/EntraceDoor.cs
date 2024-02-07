using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EntraceDoor : MonoBehaviour
{
    private Animator animator;
    private bool openedentrance;
    private CollectibleArtifact colartifact;
    private DoorActions entrance;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        colartifact = GameObject.FindObjectOfType<CollectibleArtifact>();
        entrance = GameObject.FindObjectOfType<DoorActions>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider col)
    {
        if(col.transform.tag == "Player")
        {
            if (Input.GetKey(KeyCode.F) && openedentrance == false && colartifact.artifact == true)
            {
                animator.Play("door_1_open", 0, 0.0f);
                openedentrance = true;
                entrance.Blockade.SetActive(false);
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        {
            if (openedentrance == true)
            {
                animator.Play("door_1_close", 0, 0.0f);
                openedentrance = false;
                entrance.Blockade.SetActive(true);
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    private Animator animator;
    private bool opened;
    private Collectible5 collectibles;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        collectibles = GameObject.FindObjectOfType<Collectible5>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider col)
    {
        if(col.transform.tag == "Player")
        {
            if (Input.GetKey(KeyCode.F) && opened == false && collectibles.card5 == true)
            {
                animator.Play("door_3_open", 0, 0.0f);
                opened = true;
            }
            
        }
    }

    void OnTriggerExit(Collider col)
    {
        {
            if (opened == true)
            {
                animator.Play("door_3_close", 0, 0.0f);
                opened = false;
            }
            
        }
    }
}

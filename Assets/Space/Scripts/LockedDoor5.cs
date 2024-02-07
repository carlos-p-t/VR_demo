using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor5 : MonoBehaviour
{
    private Animator animator;
    private bool opened5;
    private Collectible5 collectible5;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        collectible5 = GameObject.FindObjectOfType<Collectible5>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider col)
    {
        if(col.transform.tag == "Player")
        {
            if (Input.GetKey(KeyCode.F) && opened5 == false && collectible5.card5 == true)
            {
                animator.Play("door_3_open", 0, 0.0f);
                opened5 = true;
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        {
            if (opened5 == true)
            {
                animator.Play("door_3_close", 0, 0.0f);
                opened5 = false;
            }
        }
    }
}

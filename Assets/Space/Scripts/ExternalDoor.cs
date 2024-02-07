using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalDoor : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        BoxCollider Player = col.GetComponent<BoxCollider>();
        if(Player)
        {
            animator.Play("door_2_open", 0, 0.0f);
        }
    }

    void OnTriggerExit(Collider col)
    {
        BoxCollider Player = col.GetComponent<BoxCollider>();
        if(Player)
        {
            animator.Play("door_2_close", 0, 0.0f);
        }
    }
}

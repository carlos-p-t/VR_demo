using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor1 : MonoBehaviour
{
    private Animator animator;
    private bool opened1;
    private Collectible1 collectible1;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        collectible1 = GameObject.FindObjectOfType<Collectible1>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider col)
    {
        if(col.transform.tag == "Player")
        {
            if (Input.GetKey(KeyCode.F) && opened1 == false && collectible1.card1 == true)
            {
                animator.Play("door_3_open", 0, 0.0f);
                opened1 = true;
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        {
            if (opened1 == true)
            {
                animator.Play("door_3_close", 0, 0.0f);
                opened1 = false;
            }
        }
    }
}

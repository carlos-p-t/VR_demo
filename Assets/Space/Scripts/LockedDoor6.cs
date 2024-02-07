using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor6 : MonoBehaviour
{
    private Animator animator;
    private bool opened6;
    private Collectible6 collectible6;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        collectible6 = GameObject.FindObjectOfType<Collectible6>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider col)
    {
        if(col.transform.tag == "Player")
        {
            if (Input.GetKey(KeyCode.F) && opened6 == false && collectible6.card6 == true)
            {
                animator.Play("door_3_open", 0, 0.0f);
                opened6 = true;
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        {
            if (opened6 == true)
            {
                animator.Play("door_3_close", 0, 0.0f);
                opened6 = false;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor3 : MonoBehaviour
{
    private Animator animator;
    private bool opened3;
    private Collectible3 collectible3;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        collectible3 = GameObject.FindObjectOfType<Collectible3>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider col)
    {
        if(col.transform.tag == "Player")
        {
            if (Input.GetKey(KeyCode.F) && opened3 == false && collectible3.card3 == true)
            {
                animator.Play("door_3_open", 0, 0.0f);
                opened3 = true;
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        {
            if (opened3 == true)
            {
                animator.Play("door_3_close", 0, 0.0f);
                opened3 = false;
            }
        }
    }
}

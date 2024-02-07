using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor4 : MonoBehaviour
{
    private Animator animator;
    private bool opened4;
    private Collectible4 collectible4;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        collectible4 = GameObject.FindObjectOfType<Collectible4>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider col)
    {
        if(col.transform.tag == "Player")
        {
            if (Input.GetKey(KeyCode.F) && opened4 == false && collectible4.card4 == true)
            {
                animator.Play("door_3_open", 0, 0.0f);
                opened4 = true;
            }
        }
    }

    void OnTriggerExit(Collider col)
    {
        {
            if (opened4 == true)
            {
                animator.Play("door_3_close", 0, 0.0f);
                opened4 = false;
            }
        }
    }
}

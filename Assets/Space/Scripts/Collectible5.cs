using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectible5 : MonoBehaviour
{
    public GameObject Instruction;
    public GameObject CardTrigger;
    public GameObject ObjectOnGround;
    public bool card5;
    public bool Action = false;
    // Start is called before the first frame update
    void Start()
    {
        Instruction.SetActive(false);
        CardTrigger.SetActive(true);
        ObjectOnGround.SetActive(true);
        card5 = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.transform.tag == "Player")
        {
            Instruction.SetActive(true);
            Action = true;
        }
    }

    void OnTriggerExit(Collider col)
    {
        Instruction.SetActive(false);
        Action = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(Action == true)
            {
                Instruction.SetActive(false);
                ObjectOnGround.SetActive(false);
                CardTrigger.SetActive(false);
                Action = false;
                card5 = true;
                //Debug.Log(card5);
            }
        }
    }
}

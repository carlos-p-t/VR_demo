using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleArtifact : MonoBehaviour
{
    public GameObject Instruction;
    public GameObject ObjectTrigger;
    public GameObject ObjectOnGround;
    public GameObject Ship;
    public bool artifact;
    public bool Action = false;
    // Start is called before the first frame update
    void Start()
    {
        Instruction.SetActive(false);
        ObjectTrigger.SetActive(true);
        ObjectOnGround.SetActive(true);
        artifact = false;
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
                ObjectTrigger.SetActive(false);
                Action = false;
                artifact = true;
                Ship.SetActive(false);
            }
        }
    }
}

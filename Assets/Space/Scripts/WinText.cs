using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental;
using UnityEngine;

public class WinText : MonoBehaviour
{
    public GameObject Message;
    private CollectibleArtifact colartifact;
    // Start is called before the first frame update
    void Start()
    {
        Message.SetActive(false);
        colartifact = GameObject.FindObjectOfType<CollectibleArtifact>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.transform.tag == "Player" && colartifact.artifact == true)
        {
            Message.SetActive(true);
        }
        
    }
}

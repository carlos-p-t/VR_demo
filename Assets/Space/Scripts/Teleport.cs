using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject lookTransform;
    public GameObject Pointer;
    public float teleportSpeed = 5.0f;
    public float teleportDistance = 4.0f;

    private bool active = false;
    private float t = 0.0f;
    private Vector3 startPosition = Vector3.zero;
    private Vector3 targetPosition = Vector3.zero;
    private bool isTeleporting = false;
    private GameObject PlayerCamera;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCamera = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && active == false)
        {
            Pointer.gameObject.SetActive(true);
            active = true;
        }
        else if (Input.GetKeyDown(KeyCode.F) && active == true)
        {
            Pointer.gameObject.SetActive(false);
            active = false;
        }

        if (active)
        {
            if(isTeleporting)
            {
                transform.position = Vector3.Lerp(startPosition, targetPosition, t);
                t += Time.deltaTime * teleportSpeed;
                isTeleporting = (t <= 1.0f);
                return;
            }
            RaycastHit hit;
            if(Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out hit, Mathf.Infinity))
            {
                Vector3 hitPoint = hit.point;
                hitPoint.y = 0;
                Vector3 direction = hitPoint - transform.position;
                Vector3 targetPos = transform.position + direction.normalized * teleportDistance;
                targetPos.y = 0;
                lookTransform.transform.position = targetPos;

                if (direction.magnitude < (targetPos - transform.position).magnitude)
                {
                    lookTransform.transform.position = hitPoint;
                }
            }
            
            if (Input.GetMouseButtonDown(0))
            {
                isTeleporting = true;
                startPosition = transform.position;
                targetPosition = new Vector3(lookTransform.transform.position.x, transform.position.y, lookTransform.transform.position.z);
                t = 0.0f;
            }
        }
        
    }
}

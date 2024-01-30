using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float rotationSpeed = 10.0f;
    public float movementSpeed = 5.0f;
    public float jumpForce = 10.0f;
    public float torqueSpeed = 10.0f;
    private GameObject Player;
    Rigidbody rb;
    // Start is called before the first frame update

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * Time.deltaTime * rotationSpeed, 0);
        transform.Rotate(Input.GetAxis("Mouse Y") * Time.deltaTime * -rotationSpeed, 0, 0);
        if(Input.GetKey(KeyCode.W)) //Change to down if using Force
        {
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
            //rb.AddForce(Vector3.forward * jumpForce);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * movementSpeed * Time.deltaTime;
            //rb.AddForce(Vector3.forward * -jumpForce);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * movementSpeed * Time.deltaTime;
            //rb.AddForce(Vector3.right * jumpForce);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * movementSpeed * Time.deltaTime;
            //rb.AddForce(Vector3.right * -jumpForce);
        }
        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate (0, 0, torqueSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 0, -torqueSpeed * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce * 2);
        }
    }
}

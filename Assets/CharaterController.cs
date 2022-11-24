using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterController : MonoBehaviour
{
    
    public float maxSpeed = 3.0f;
    float rotation = 0.0f;
    float camRotation = 0.0f;
    GameObject cam;
    Rigidbody myRigidbody;

    bool isOnGround;
    public GameObject groundChecker;
    public LayerMask groundLayer;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        cam = GameObject.Find("Main Camera");
        myRigidbody = GetComponent<Rigidbody>();
    }

    
    

    void Update()
    {
       isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.1f, groundLayer);

       Vector3 newVelocity = (transform.forward * Input.GetAxis("Vertical") * maxSpeed)  + (transform.right * Input.GetAxis("Horizontal") * maxSpeed);
       myRigidbody.velocity = new Vector3(newVelocity.x, newVelocity.y, newVelocity.z);

        rotation = rotation + Input.GetAxis("Mouse x");
        transform.rotation = Quaternion.Euler(new Vector3(0.0f,rotation, 0.0f));
        
        camRotation = camRotation + Input.GetAxis("Mouse Y");
        cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0.0f, 0.0f));
    }}



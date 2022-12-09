using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterController : MonoBehaviour
{
    
    public float maxSpeed = 3.0f;
    public float rotation = 0.0f;
    public float camRotation = 0.0f;
    GameObject cam;
    Rigidbody myRigidbody;
<<<<<<< HEAD
    public Animator  myAnim;
=======

    bool isOnGround;
    public GameObject groundChecker;
    public LayerMask groundLayer;


>>>>>>> 8f1050081e33f53cabb984a97f81927b4192503a
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        cam = GameObject.Find("Main Camera");
        myRigidbody = GetComponent<Rigidbody>();
    }

    
    

    void Update()
    {
<<<<<<< HEAD
       

       Vector3 newVelocity = transform.forward * Input.GetAxis("Vertical") * maxSpeed;
       myRigidbody.velocity = new Vector3(newVelocity.x, myRigidbody.velocity.y, newVelocity.z);
=======
       isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.1f, groundLayer);

       Vector3 newVelocity = (transform.forward * Input.GetAxis("Vertical") * maxSpeed)  + (transform.right * Input.GetAxis("Horizontal") * maxSpeed);
       myRigidbody.velocity = new Vector3(newVelocity.x, newVelocity.y, newVelocity.z);
>>>>>>> 8f1050081e33f53cabb984a97f81927b4192503a

       myAnim.SetFloat("speed" , newVelocity.magnitude);

        rotation = rotation + Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(new Vector3(0.0f,rotation, 0.0f));
        
        camRotation = camRotation + Input.GetAxis("Mouse Y");
        cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0.0f, 0.0f));
    }
    
}



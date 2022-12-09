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
    public Animator  myAnim;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
        myRigidbody = GetComponent<Rigidbody>();
    }

    
    

    void Update()
    {
       

       Vector3 newVelocity = transform.forward * Input.GetAxis("Vertical") * maxSpeed;
       myRigidbody.velocity = new Vector3(newVelocity.x, myRigidbody.velocity.y, newVelocity.z);

       myAnim.SetFloat("speed" , newVelocity.magnitude);

        rotation = rotation + Input.GetAxis("Mouse X");
        transform.rotation = Quaternion.Euler(new Vector3(0.0f,rotation, 0.0f));
        
        camRotation = camRotation + Input.GetAxis("Mouse Y");
        cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0.0f, 0.0f));
    }
    
}



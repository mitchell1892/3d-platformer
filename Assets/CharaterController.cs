using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterController : MonoBehaviour
{
    
    public float maxSpeed = 3.0f;
    float rotation = 0.0f;
    float camRotation = 0.0f;
    GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
    }

    
    

    void Update()
    {
       transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical") * maxSpeed) + (transform.right * Input.GetAxis("Horizontal") * maxSpeed);


        rotation = rotation + Input.GetAxis("Mouse x");
        transform.rotation = Quaternion.Euler(new Vector3(0.0f,rotation, 0.0f));
        
        camRotation = camRotation + Input.GetAxis("Mouse Y");
        cam.transform.localRotation = Quaternion.Euler(new Vector3(camRotation, 0.0f, 0.0f));
    }}



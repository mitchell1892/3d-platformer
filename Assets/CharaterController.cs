using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharaterController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float maxSpeed = 3.0f;
    float rotation = 0.0f;

    void Update()
    {
       transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical"));

        rotation = rotation + Input.GetAxis("Mouse x");
        transform.rotation = Quaternion.Euler(new Vector3(0.0f,rotation, 0.0f));
    }
}



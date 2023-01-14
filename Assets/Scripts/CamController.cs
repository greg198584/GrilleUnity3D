using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public float speed = 5;
    public float speedScroll = 10;
    private Camera cam;
    private void FixedUpdate()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        Vector3 dir = transform.forward * zInput + transform.right * xInput;

        transform.position += dir * (speed * Time.deltaTime);

        if (Input.GetAxis("Mouse ScrollWheel") != 0f)
        {
            cam.fieldOfView += Input.GetAxis("Mouse ScrollWheel") * speedScroll;
            if (cam.fieldOfView < 30)
                cam.fieldOfView = 30;
            if (cam.fieldOfView > 90)
                cam.fieldOfView = 90;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

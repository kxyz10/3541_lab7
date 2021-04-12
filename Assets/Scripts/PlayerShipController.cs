﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipController : MonoBehaviour
{


    public float movementSpeed = 20.0f;
    public float rotationSpeed = 10.0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(transform.right), rotationSpeed * Time.deltaTime);
            //transform.LookAt(transform.right * Time.deltaTime);
            float damping = 2.0f;
            //float rotate = Mathf.Lerp(transform.right, transform.position.y, damping * Time.deltaTime);
            //transform.Rotate(Vector3.up * rotate);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(-transform.right), rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(transform.forward,transform.up), rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(transform.forward, -transform.up), rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * Time.deltaTime, Space.Self);
        }
    }

    Vector3 getDirection()
    {
        Vector3 direction = new Vector3(0,0,0);
        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += -Vector3.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += -Vector3.right;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector3.left;
        }
        return direction;
    }
}

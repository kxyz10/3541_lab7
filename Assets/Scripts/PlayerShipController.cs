using System.Collections;
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
        //Vector3 direction = getDirection();
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        if(moveHorizontal != 0 || moveVertical != 0)
        {
            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            var q = Quaternion.LookRotation(movement - transform.position);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, rotationSpeed * Time.deltaTime);
        }


        //transform.rotation = Quaternion.LookRotation(movement * Time.deltaTime);


        //transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);
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

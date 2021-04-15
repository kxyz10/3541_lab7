using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipController : MonoBehaviour
{

    public float cameraSensitivity = 1.0f;
    public float moveSpeed = 10.0f;
    private float xRotation = 0.0f;
    private float yRotation = 0.0f;
    private Camera camera;
    CharacterController shipController;

    void Start()
    {
        camera = Camera.main;
        shipController = GetComponent<CharacterController>();

    }

    void Update()
    {

        // mouse movement
        float cameraX = Input.GetAxis("Mouse X") * cameraSensitivity;
        float cameraY = Input.GetAxis("Mouse Y") * cameraSensitivity;
        yRotation += cameraX;
        xRotation -= cameraY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        camera.transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);

        // spaceship movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float forward = 0.0f;
        if (Input.GetKey(KeyCode.Space))
        {
            forward = 1;
        }
        shipController.Move((Vector3.right * horizontal + Vector3.up * vertical + Vector3.forward * forward) * Time.deltaTime * moveSpeed);
    }
}

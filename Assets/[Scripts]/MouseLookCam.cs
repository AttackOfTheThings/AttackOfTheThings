using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookCam : MonoBehaviour
{
    public float mouseSensitivity = 2000f;
    public Transform playerBody;
    float xRotation = 0f;
    public float speed = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation* speed, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX* speed);

    }
}

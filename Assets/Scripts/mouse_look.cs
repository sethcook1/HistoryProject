using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_look : MonoBehaviour
{
    public float mouseSens = 150f;
    public Transform playerBody;
    public KeyCode menuButton;
    public KeyCode exitButton;
    float xRotation = 0f;
    private bool cursorLocked;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState=CursorLockMode.Locked;
        cursorLocked = true;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        if (Input.GetKeyDown(menuButton) && cursorLocked)
        {   
            Cursor.lockState=CursorLockMode.None;
            cursorLocked = false;   
        }

        if (Input.GetKeyDown(exitButton) && !cursorLocked)
        {
            Cursor.lockState=CursorLockMode.Locked;
            cursorLocked = true;
        }
        

        xRotation -= mouseY;
        xRotation= Mathf.Clamp(xRotation,-90f,90f);

        if (cursorLocked)
        {
            transform.localRotation=Quaternion.Euler(xRotation,0f,0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
        


    }
}

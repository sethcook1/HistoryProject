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
    private bool cursorLocked = false;
    private GameObject playerObj;
    private GameObject startMenu;

    // Start is called before the first frame update
    void Start()
    {
        playerObj = GameObject.Find("Player");
        startMenu = GameObject.Find("StartMenu");
        Cursor.lockState=CursorLockMode.Locked;
        cursorLocked = true;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (!playerObj.GetComponent<OpenMenu>().menuOpen & !cursorLocked & !startMenu.activeInHierarchy)
        {
            Cursor.lockState=CursorLockMode.Locked;
            cursorLocked = true;
        }

        if (playerObj.GetComponent<OpenMenu>().menuOpen & cursorLocked)
        {
            Cursor.lockState=CursorLockMode.None;
            cursorLocked = false;
        }
        */

        float mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;
        xRotation -= mouseY;
        xRotation= Mathf.Clamp(xRotation,-90f,90f);
        transform.localRotation=Quaternion.Euler(xRotation,0f,0f);
        playerBody.Rotate(Vector3.up * mouseX);
        
        
    }
}

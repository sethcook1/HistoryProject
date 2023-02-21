
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f; //Controls velocity multiplier

    

    Rigidbody rb; //Tells script there is a rigidbody, we can use variable rb to reference it in further script

    public Transform orientation;
    public float turnSpeed = 4.0f;
    public float moveSpeed = 2.0f;
    public float minTurnAngle = -90.0f;
    public float maxTurnAngle = 90.0f;
    private float rotX;

    //groundCheck Drag
    public float playerHeight;
    public LayerMask whatisGround;
    public float groundDrag;
    bool grounded;


    float horizontalInput;
    float verticalInput;
    Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation=true;
       // Cursor.lockState= CursorLockMode.Locked;
        //Cursor.visible=false; 
    }


    // Update is called once per frame
    void Update()
    {
        MouseAiming();
        //original code

        //ground check
        grounded =Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f +0.2f, whatisGround);

       //input 
       horizontalInput = Input.GetAxisRaw("Horizontal"); 
       verticalInput = Input.GetAxisRaw("Vertical"); 
        speedControl();

        //handle drag
        if(grounded)
            rb.drag= groundDrag;

        else
        {
            rb.drag = 0;    
        }



    }
    void FixedUpdate()
    {
        Moveplayer();

    }

    void Moveplayer()
    {
        moveDirection=orientation.forward *verticalInput +orientation.right * horizontalInput;
        rb.AddForce(moveDirection.normalized * moveSpeed *speed, ForceMode.Force);



    }

    void MouseAiming()
    {
        // get the mouse inputs
        float y = Input.GetAxis("Mouse X") * turnSpeed;
        rotX += Input.GetAxis("Mouse Y") * turnSpeed;
        // clamp the vertical rotation
        rotX = Mathf.Clamp(rotX, minTurnAngle, maxTurnAngle);
        // rotate the camera
        transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + y, 0);
    }

    void speedControl()
{
    Vector3 flatVel = new Vector3(rb.velocity.x,0f,rb.velocity.z);

    if(flatVel.magnitude > moveSpeed)
    {
        Vector3 limitedVel =flatVel.normalized*moveSpeed;
        rb.velocity= new Vector3(limitedVel.x,rb.velocity.y,limitedVel.z);


    }


}



}


    
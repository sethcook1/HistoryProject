
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

    //groundCheck Drag
    public float playerHeight;
    public LayerMask whatisGround;
    public float groundDrag;
    bool grounded;

    //jump Controls
    [Header("Keybinds")]
    public KeyCode jumpKey = KeyCode.Space;
     public float jumpForce = 5;
    public float jumpCoolDown;
    public float airMultiplier;
    bool readyToJump = true;


    float horizontalInput;
    float verticalInput;
    Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation=true;

        //Cursor.visible=false; 
    }


    // Update is called once per frame
    void Update()
    {
        //ground check
        grounded =Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f +0.2f, whatisGround);

       //input 
       horizontalInput = Input.GetAxisRaw("Horizontal"); 
       verticalInput = Input.GetAxisRaw("Vertical"); 
        
         //handle drag
        if(grounded)
            rb.drag= groundDrag;
         else
        {
            rb.drag = 0;    
        }


        //when to jump
        if(Input.GetKey(jumpKey) && readyToJump  && grounded)

        {
            readyToJump = false;

            Jump();

            Invoke(nameof(ResetJump), jumpCoolDown);

        }

    }

    //calls player movement
    void FixedUpdate()
    {
        Moveplayer();

    }

    //does player movementss and if player is on ground
     void Moveplayer()
    {
        moveDirection=orientation.forward *verticalInput +orientation.right * horizontalInput;
        //rb.AddForce(moveDirection.normalized * moveSpeed *speed, ForceMode.Acceleration);
    //updated stuff

    //on ground
        if(grounded)
            rb.AddForce(moveDirection.normalized * moveSpeed * speed, ForceMode.Acceleration);

    //in air
        else if(!grounded)
            rb.AddForce(moveDirection.normalized * moveSpeed * speed * airMultiplier, ForceMode.Force);

    }

    void speedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x,0f,rb.velocity.z);
     //limited velocity if needed
        if(flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel =flatVel.normalized*moveSpeed;
            rb.velocity= new Vector3(limitedVel.x,rb.velocity.y,limitedVel.z);
        }
    }

    void Jump()
    {

        //reset y velocity
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
     rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);


    }

    void ResetJump()
    {
        readyToJump =true;
     }









}


    
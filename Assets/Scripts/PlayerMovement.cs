using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f; //Controls velocity multiplier

    Rigidbody rb; //Tells script there is a rigidbody, we can use variable rb to reference it in further script

    public float turnSpeed = 4.0f;
    public float moveSpeed = 2.0f;
    public float minTurnAngle = -90.0f;
    public float maxTurnAngle = 90.0f;
    private float rotX;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }


    // Update is called once per frame
    void Update()
    {
        MouseAiming();

        float xMove = Input.GetAxisRaw("Horizontal"); 
        float zMove = Input.GetAxisRaw("Vertical"); 
        rb.velocity = new Vector3(xMove, rb.velocity.y, zMove) * speed; 
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
}
    
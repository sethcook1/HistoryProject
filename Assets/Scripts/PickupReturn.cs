using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupReturn : MonoBehaviour
{
    private Vector3 objOriginalPosition;  //stores the position the object was at start
    private Quaternion objOriginalRotation;  //stores the rotation the object was at start
    private Rigidbody selfRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //store where the object is located at start. This defines where we will return it to.
        objOriginalPosition = this.transform.position;
        objOriginalRotation = this.transform.rotation;
        selfRigidbody = (Rigidbody)this.GetComponent("Rigidbody");
    }

    // Update is called once per frame
    void Update()
    {
        if (!selfRigidbody.isKinematic) //the pickup script sets the object to be kinematic when picked up, and disables it when it is not picked up.
        {
            this.transform.position = objOriginalPosition;
            this.transform.rotation = objOriginalRotation;
        }
    }
}

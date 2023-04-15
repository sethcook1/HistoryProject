using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectionScript : MonoBehaviour
{
    public Camera view;                     //the player's camera
    public GameObject collided_obj = null;  //the object hit by a raycast, or the object grabbed from the pickup script, depending on what functions are uncommented.
    public string objecthitName;            //object's name, if an InspectInfo script is present on collided_obj
    public string objecthitInfo;            //object's info, if an InspectInfo script is present on collided_obj
    private Ray ray_direction;              //holds the direction we want the raycast to go
    private RaycastHit hit;                 //holds information on what the raycast it
    private GameObject pickupScriptObj;     //the object that the PickUpScript is on

    // Start is called before the first frame update
    void Start()
    {
        view = (Camera)GameObject.Find("Camera").GetComponent("Camera");
        pickupScriptObj = view.gameObject;
    }

    /*
    void FixedUpdate()
    {
        //send a ray in the direction we are looking (the center of the player's camera)
        ray_direction = view.ScreenPointToRay(Input.mousePosition);
        
        //if the ray hits a collider
        if (Physics.Raycast(ray_direction, out hit))
        {
            Debug.DrawRay(ray_direction.origin, ray_direction.direction * 100, Color.yellow, 1);
            collided_obj = hit.collider.gameObject;
            if (collided_obj.GetComponent<InspectInfo>() != null) //check if the collider we hit has an InspectInfo component on it
            {
                objecthitName = collided_obj.GetComponent<InspectInfo>().objectName;
                objecthitInfo = collided_obj.GetComponent<InspectInfo>().objectInfo;
            }
            else //the component is missing
            {
                objecthitName = "";
                objecthitInfo = "";
            }
            
        }
        //if the ray does not hit anything
        else
        {
            Debug.DrawRay(ray_direction.origin, ray_direction.direction * 100, Color.yellow, 1);
        }
    }
    */
    
    void Update()
    {
        if (pickupScriptObj.GetComponent<PickUpScript>().heldObj != null) //if an object is being held
        {
            collided_obj = pickupScriptObj.GetComponent<PickUpScript>().heldObj;
        }
        if (collided_obj.GetComponent<InspectInfo>() != null) //check if the object picked up has an InspectInfo component on it
        {
            objecthitName = collided_obj.GetComponent<InspectInfo>().objectName;
            objecthitInfo = collided_obj.GetComponent<InspectInfo>().objectInfo;
        }
        else //the component is missing
        {
            objecthitName = "";
            objecthitInfo = "";
        }
    }
    
}

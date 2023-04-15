using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectionScript : MonoBehaviour
{
    public Camera view;
    public GameObject collided_obj = null;
    public KeyCode rayButton;
    public Ray ray_direction;
    public string objecthitName;
    public string objecthitInfo;
    private RaycastHit hit;
    private GameObject pickupScriptObj;

    // Start is called before the first frame update
    void Start()
    {
        view = (Camera)GameObject.Find("Camera").GetComponent("Camera");
        pickupScriptObj = view.gameObject;
    }

    // Update is called once per frame
    
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectionScript : MonoBehaviour
{
    public Camera view;
    public GameObject collided_obj;
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
    
    void FixedUpdate()
    {
        ray_direction = view.ScreenPointToRay(Input.mousePosition);
           
        if (Physics.Raycast(ray_direction, out hit))
        {
            Debug.DrawRay(ray_direction.origin, ray_direction.direction * 100, Color.yellow, 1);
            collided_obj = hit.collider.gameObject;
            objecthitName = collided_obj.GetComponent<InspectInfo>().objectName;
            objecthitInfo = collided_obj.GetComponent<InspectInfo>().objectInfo;
        }

        else
        {
            Debug.DrawRay(ray_direction.origin, ray_direction.direction * 100, Color.yellow, 1);
        }
    }
    
    /*
    void Update()
    {
        collided_obj = pickupScriptObj.GetComponent<PickUpScript>().heldObj;
    }
    */
}

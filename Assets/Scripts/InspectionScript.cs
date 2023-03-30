using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectionScript : MonoBehaviour
{
    public Camera view;
    public GameObject collided_obj;
    public KeyCode rayButton;
    public Ray ray_direction;
    private RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
           view = (Camera)GameObject.Find("Camera").GetComponent("Camera");    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ray_direction = view.ScreenPointToRay(Input.mousePosition);
           
        if (Physics.Raycast(ray_direction, out hit))
        {
            Debug.DrawRay(ray_direction.origin, ray_direction.direction * 100, Color.yellow, 1);
            collided_obj = hit.collider.gameObject;
        }

        else
        {
            Debug.DrawRay(ray_direction.origin, ray_direction.direction * 100, Color.yellow, 1);
        }
        
    }
}

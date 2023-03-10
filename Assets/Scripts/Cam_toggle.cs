using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_toggle : MonoBehaviour
{

    //fix to camera issue

    //camera object
    public GameObject cam1 ;
  

    // Start is called before the first frame update
    void Start()
    {
        //toggle camera off and then on which
        //should fix the camera 
        cam1.SetActive(false);
        cam1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}

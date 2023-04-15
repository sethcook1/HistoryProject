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
        //a bug seemingly with WebGL causes you to not be to set a main camera. However, when a camera is enabled, it sets it as the main camera.
        //this script simply toggles the player's camera off and back on to fix this issue.
        cam1.SetActive(false);
        cam1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}

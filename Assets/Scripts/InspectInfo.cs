using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectInfo : MonoBehaviour
{
    public string objectName;            //name of the object to be displayed in the UI
    public string objectInfo;            //info of the object to be displayed in the UI
    public float objectScaleSizeF = 1;   //what the user wants to change the scale to when picked up. 1 means the object does not change scale
    public Vector3 objectScaleSize;      //vector that is calculated in this script, but utilized in PickUpScript
    // Start is called before the first frame update
    void Start()
    {
        //if the objectScaleSizeF is 1, assume that you want to not scale the object when picked up.
        if(objectScaleSizeF == 1)
        {
            objectScaleSize = this.transform.localScale;
        }
        else
        {
            objectScaleSize = new Vector3(objectScaleSizeF, objectScaleSizeF, objectScaleSizeF);
        }
        
    }
}

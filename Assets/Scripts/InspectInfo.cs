using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectInfo : MonoBehaviour
{
    public string objectName;
    public string objectInfo;
    public float objectScaleSizeF = 1;
    public Vector3 objectScaleSize;
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

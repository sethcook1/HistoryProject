using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectInfo : MonoBehaviour
{
    public string objectName;
    public string objectInfo;
    public float objectSize;
   private Vector3 originalScale;


    // Start is called before the first frame update
    void Start()
    {
        //saves original size of object
        originalScale = transform.localScale;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("e")){
            //transform.localScale=new Vector3(1,1, 1);
            this.transform.localScale = new Vector3(objectSize, objectSize, objectSize);
        }

        else if(Input.GetKeyUp("e")){
            // Set the object's scale back to its original size
            transform.localScale = originalScale;
        }
        
    }

}

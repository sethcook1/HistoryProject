using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    public GameObject holdPos;
       
    // Start is called before the first frame update
    void Start()
    {
        //holdPos = GameObject.Find("holdPosition");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Summon()
    {
        this.transform.position = holdPos.transform.position;
    }
}

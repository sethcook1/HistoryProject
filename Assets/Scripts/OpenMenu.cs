using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Image;
    private GameObject cloneImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!cloneImage)
            {
                cloneImage = Instantiate(Image, Canvas.transform, false);
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Destroy(cloneImage);
        }
    }
}

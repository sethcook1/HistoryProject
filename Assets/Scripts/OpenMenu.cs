using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Image;
    public KeyCode menuButton;
    public KeyCode exitButton;
    private GameObject cloneImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(menuButton))
        {
            if (!cloneImage)
            {
                cloneImage = Instantiate(Image, Canvas.transform, false);
            }
        }

        if (Input.GetKeyDown(exitButton))
        {
            Destroy(cloneImage);
        }
    }
}

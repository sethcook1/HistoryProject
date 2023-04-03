using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Image;
    public GameObject startMenu;
    private GameObject cloneMenu;
    public KeyCode menuButton;
    public KeyCode exitButton;
    private GameObject cloneImage;

    // Start is called before the first frame update
    void Start()
    {
        cloneMenu = Instantiate(startMenu, Canvas.transform, false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(menuButton) & !cloneImage)
        {
            cloneImage = Instantiate(Image, Canvas.transform, false);
        }

        if (Input.GetKeyDown(exitButton) & cloneImage)
        {
            Destroy(cloneImage);
        }

        if (Input.GetKeyDown(exitButton) & cloneMenu)
        {
            Destroy(cloneMenu);
        }
    }

}

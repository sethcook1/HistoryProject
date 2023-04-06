using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject Image;
    public GameObject startMenu;
    private GameObject itemMenu;
    public KeyCode menuButton;
    public KeyCode exitButton;
    private GameObject cloneImage;

    // Start is called before the first frame update
    void Start()
    {
        //cloneMenu = Instantiate(startMenu, Canvas.transform, false);
        itemMenu = GameObject.Find("ItemMenu");
        itemMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(menuButton) & !cloneImage)
        {
            itemMenu.SetActive(true);
        }

        /*
        if (Input.GetKeyDown(exitButton) & cloneImage)
        {
            Destroy(cloneImage);
        }
        */

        if (Input.GetKeyDown(exitButton) & itemMenu)
        {
            itemMenu.SetActive(false);
        }
    }

}

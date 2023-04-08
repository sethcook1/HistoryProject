using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject Canvas;
    private GameObject startMenu;
    private GameObject itemMenu;
    public KeyCode menuButton;
    public KeyCode exitButton;

    // Start is called before the first frame update
    void Start()
    {
        //cloneMenu = Instantiate(startMenu, Canvas.transform, false);
        itemMenu = GameObject.Find("ItemMenu");
        startMenu = GameObject.Find("StartMenu");
        startMenu.SetActive(true);
        itemMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(menuButton) & !itemMenu.activeInHierarchy)
        {
            itemMenu.SetActive(true);
        }

        if (Input.GetKeyDown(exitButton) & itemMenu.activeInHierarchy)
        {
            itemMenu.SetActive(false);
        }

        if (Input.GetKeyDown(exitButton) & startMenu.activeInHierarchy)
        {
            startMenu.SetActive(false);
        }
    }

}

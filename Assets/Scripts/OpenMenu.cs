using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject Canvas;
    private GameObject startMenu;
    private GameObject playerCam;
    private GameObject sugNipInfo;
    private int sugNipId;
    private GameObject defaultInfo;
    private int objHeld;
    private GameObject curOpenMenu;
    public KeyCode menuButton;
    public KeyCode exitButton;
    public bool menuOpen;

    // Start is called before the first frame update
    void Start()
    {
        //cloneMenu = Instantiate(startMenu, Canvas.transform, false);
        sugNipInfo = GameObject.Find("SugarNipperInfo");
        sugNipId = GameObject.Find("SugarNippers").gameObject.GetInstanceID();
        defaultInfo = GameObject.Find("InfoTemplate");
        playerCam = GameObject.Find("Camera");
        startMenu = GameObject.Find("StartMenu");
        sugNipInfo.SetActive(false);
        defaultInfo.SetActive(false);
        startMenu.SetActive(true);
        menuOpen = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(exitButton) & startMenu.activeInHierarchy)
        {
            startMenu.SetActive(false);
            menuOpen = false;
        }

        if (playerCam.GetComponent<PickUpScript>().isHolding & !menuOpen)
        {
            menuOpen = true;
            objHeld = playerCam.GetComponent<PickUpScript>().heldObj.gameObject.GetInstanceID();

            if (objHeld == sugNipId)
            {
                curOpenMenu = sugNipInfo;
                curOpenMenu.SetActive(true);
            }

            else
            {
                curOpenMenu = defaultInfo;
                curOpenMenu.SetActive(true);
            }

            /*
            switch (objHeld)
            {
                case sugNipId:
                {
                    curOpenMenu = sugNipInfo;
                    curOpenMenu.SetActive(true);
                    break;
                }

                default:
                {
                    curOpenMenu = defaultInfo;
                    curOpenMenu.SetActive(true);
                    break;
                }
            }
            */
        }

        if (!playerCam.GetComponent<PickUpScript>().isHolding & menuOpen)
        {
            menuOpen = false;
            curOpenMenu.SetActive(false);
        }
    }

}

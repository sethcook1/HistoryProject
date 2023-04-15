using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenMenu : MonoBehaviour
{
    public GameObject Canvas;             //object for the Canvas
    private GameObject startMenu;         //object for the startMenu
    private GameObject playerCam;         //the player's camera
    private GameObject playerObj;         //the object that is the player
    private GameObject objectMenu;        //object that is the Info UI
    public TextMeshProUGUI objectName;    //UI textbox for the Name
    public TextMeshProUGUI objectInfo;    //UI textbox for the Info
    public KeyCode exitButton;            //button that is pressed to exit the menu
    public bool menuOpen;                 //true if the menu is open
    
    
    // Start is called before the first frame update
    void Start()
    {
        playerCam = GameObject.Find("Camera");
        startMenu = GameObject.Find("StartMenu");
        playerObj = GameObject.Find("Player");
        objectMenu = GameObject.Find("InfoTemplate");
        objectMenu.SetActive(false);
        startMenu.SetActive(true);        
        menuOpen = true;
    }

    // Update is called once per frame
    void Update()
    {
        objectName.text = playerObj.GetComponent<InspectionScript>().objecthitName;
        objectInfo.text = playerObj.GetComponent<InspectionScript>().objecthitInfo;
        if (Input.GetKeyDown(exitButton) & startMenu.activeInHierarchy)
        {
            startMenu.SetActive(false);
            menuOpen = false;
        }

        if (playerCam.GetComponent<PickUpScript>().isHolding & !menuOpen)
        {
            menuOpen = true;
            objectMenu.SetActive(true);           
        }

        if (!playerCam.GetComponent<PickUpScript>().isHolding & menuOpen)
        {
            menuOpen = false;
            objectMenu.SetActive(false);
        }
    }

}

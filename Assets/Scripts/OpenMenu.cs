using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenMenu : MonoBehaviour
{
    public GameObject Canvas;
    private GameObject startMenu;
    private GameObject playerCam;
    private GameObject playerObj;
    private GameObject objectMenu;
    public TextMeshProUGUI objectName;
    public TextMeshProUGUI objectInfo;
    public KeyCode menuButton;
    public KeyCode exitButton;
    public bool menuOpen;

    // Start is called before the first frame update
    void Start()
    {
        playerCam = GameObject.Find("Camera");
        startMenu = GameObject.Find("StartMenu");
        playerObj = GameObject.Find("Player");
        objectMenu = GameObject.Find("InfoTemplate");
        objectMenu.gameObject.SetActive(false);
        startMenu.gameObject.SetActive(true);        
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
            objectName.text = playerObj.GetComponent<InspectionScript>().objecthitName;
            objectInfo.text = playerObj.GetComponent<InspectionScript>().objecthitInfo;
            objectMenu.gameObject.SetActive(true);           
        }

        if (!playerCam.GetComponent<PickUpScript>().isHolding & menuOpen)
        {
            menuOpen = false;
            objectMenu.gameObject.SetActive(false);
        }
    }

}

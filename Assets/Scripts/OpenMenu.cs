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
    private GameObject brownMugInfo;
    private int brownMugId;
    private GameObject broomInfo;
    private int broomId;
    private GameObject bucketInfo;
    private int bucketId;
    private GameObject pewterPlateInfo;
    private int pewterPlateId;
    private GameObject woodenStoolInfo;
    private int woodenStoolId;
    //private GameObject flowerPotInfo;
    //private int flowerPotId;
    private GameObject hornSpoonInfo;
    private int hornSpoonId1;
    private int hornSpoonId2;
    private int hornSpoonId3;
    private GameObject smokingPipeInfo;
    private int smokingPipeId;
    private GameObject woodenSpoonInfo;
    private int woodenSpoonId;
    private GameObject coatInfo;
    private int coatId;
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
        brownMugInfo = GameObject.Find("BrownGlazedMugInfo");
        brownMugId = GameObject.Find("BrownGlazedMug").gameObject.GetInstanceID();
        broomInfo = GameObject.Find("BroomInfo");
        broomId = GameObject.Find("Broom").gameObject.GetInstanceID();
        bucketInfo = GameObject.Find("BucketInfo");
        bucketId = GameObject.Find("Bucket").gameObject.GetInstanceID();
        pewterPlateInfo = GameObject.Find("PewterPlateInfo");
        pewterPlateId = GameObject.Find("PewterPlate").gameObject.GetInstanceID();
        woodenStoolInfo = GameObject.Find("WoodenStoolInfo");
        woodenStoolId = GameObject.Find("WoodenStool").gameObject.GetInstanceID();
        //flowerPotInfo = GameObject.Find("FlowerPotInfo");
        //flowerPotId = GameObject.Find("flowerpot??").gameObject.GetInstanceID();
        hornSpoonInfo = GameObject.Find("HornSpoonInfo");
        hornSpoonId1 = GameObject.Find("HornSpoon1").gameObject.GetInstanceID();
        hornSpoonId2 = GameObject.Find("HornSpoon2").gameObject.GetInstanceID();
        hornSpoonId3 = GameObject.Find("HornSpoon3").gameObject.GetInstanceID();
        smokingPipeInfo = GameObject.Find("SmokingPipeInfo");
        smokingPipeId = GameObject.Find("SmokingPipe").gameObject.GetInstanceID();
        woodenSpoonInfo = GameObject.Find("WoodenSpoonInfo");
        woodenSpoonId = GameObject.Find("WoodenSpoon").gameObject.GetInstanceID();
        coatInfo = GameObject.Find("CoatInfo");
        coatId = GameObject.Find("Coat").gameObject.GetInstanceID();
        defaultInfo = GameObject.Find("InfoTemplate");
        playerCam = GameObject.Find("Camera");
        startMenu = GameObject.Find("StartMenu");
        sugNipInfo.SetActive(false);
        brownMugInfo.SetActive(false);
        broomInfo.SetActive(false);
        bucketInfo.SetActive(false);
        pewterPlateInfo.SetActive(false);
        woodenStoolInfo.SetActive(false);
        //flowerPotInfo.SetActive(false);
        hornSpoonInfo.SetActive(false);
        smokingPipeInfo.SetActive(false);
        woodenSpoonInfo.SetActive(false);
        coatInfo.SetActive(false);
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

            if (objHeld == brownMugId)
            {
                curOpenMenu = brownMugInfo;
                curOpenMenu.SetActive(true);
            }

            if (objHeld == broomId)
            {
                curOpenMenu = broomInfo;
                curOpenMenu.SetActive(true);
            }

            if (objHeld == bucketId)
            {
                curOpenMenu = bucketInfo;
                curOpenMenu.SetActive(true);
            }

            if(objHeld == pewterPlateId)
            {
                curOpenMenu = pewterPlateInfo;
                curOpenMenu.SetActive(true);
            }

            if(objHeld == woodenStoolId)
            {
                curOpenMenu = woodenStoolInfo;
                curOpenMenu.SetActive(true);
            }

            //if (objHeld == flowerPotId)
            //{
            //    curOpenMenu = flowerPotInfo;
            //    curOpenMenu.SetActive(true);
            //}

            if (objHeld == hornSpoonId1)
            {
                curOpenMenu = hornSpoonInfo;
                curOpenMenu.SetActive(true);
            }

            if (objHeld == hornSpoonId2)
            {
                curOpenMenu = hornSpoonInfo;
                curOpenMenu.SetActive(true);
            }

            if (objHeld == hornSpoonId3)
            {
                curOpenMenu = hornSpoonInfo;
                curOpenMenu.SetActive(true);
            }

            if (objHeld == smokingPipeId)
            {
                curOpenMenu = smokingPipeInfo;
                curOpenMenu.SetActive(true);
            }

            if (objHeld == woodenSpoonId)
            {
                curOpenMenu = woodenSpoonInfo;
                curOpenMenu.SetActive(true);
            }

            if (objHeld == coatId)
            {
                curOpenMenu = coatInfo;
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

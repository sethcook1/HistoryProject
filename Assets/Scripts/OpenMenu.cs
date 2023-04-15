using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject Canvas;
    private GameObject[] objectInfo;
    private GameObject startMenu;
    private GameObject playerCam;
    public GameObject curOpenMenu;
    /*
    private GameObject sugNipInfo;
    private GameObject brownMugInfo;
    private GameObject broomInfo;
    private GameObject bucketInfo;
    private GameObject pewterPlateInfo;
    private GameObject woodenStoolInfo;
    private GameObject hornSpoonInfo;
    private GameObject smokingPipeInfo;
    private GameObject woodenSpoonInfo;
    private GameObject coatInfo;
    private GameObject metalLadleInfo;
    private GameObject lampInfo;
    private GameObject knifeInfo;
    private GameObject hatInfo;
    private GameObject grubHoeInfo;
    private GameObject gourdLadleInfo;
    private GameObject flowerEarthenInfo;
    private GameObject candleInfo;
    private GameObject bedInfo;
    private GameObject defaultInfo;
    
    private GameObject tableInfo;
    */
    
    //private GameObject flowerPotInfo;
    //private int flowerPotId;
    
    private int objHeld;
    public KeyCode menuButton;
    public KeyCode exitButton;
    public bool menuOpen;

    // Start is called before the first frame update
    void Start()
    {
        //cloneMenu = Instantiate(startMenu, Canvas.transform, false);
        objectInfo = GameObject.FindGameObjectsWithTag("UI");
        for (int i = 0; i < objectInfo.Length; i++)
        {
            objectInfo[i].SetActive(false);
        }
        playerCam = GameObject.Find("Camera");
        startMenu = GameObject.Find("StartMenu");
        startMenu.SetActive(true);
        menuOpen = true;
        /*
        defaultInfo = GameObject.Find("InfoTemplate");
        tableInfo = GameObject.Find("TableInfo");
        metalLadleInfo = GameObject.Find("MetalLadleInfo");
        lampInfo = GameObject.Find("LampInfo");
        knifeInfo = GameObject.Find("KnifeInfo");
        hatInfo = GameObject.Find("HatInfo");
        grubHoeInfo = GameObject.Find("GrubHoeInfo");
        gourdLadleInfo = GameObject.Find("GourdLadleInfo");
        flowerEarthenInfo = GameObject.Find("FlowerEarthenInfo");
        candleInfo = GameObject.Find("CandleInfo");
        bedInfo = GameObject.Find("BedInfo");
        sugNipInfo = GameObject.Find("SugarNipperInfo");
        brownMugInfo = GameObject.Find("BrownGlazedMugInfo");
        broomInfo = GameObject.Find("BroomInfo");
        bucketInfo = GameObject.Find("BucketInfo");
        pewterPlateInfo = GameObject.Find("PewterPlateInfo");
        woodenStoolInfo = GameObject.Find("WoodenStoolInfo");
        hornSpoonInfo = GameObject.Find("HornSpoonInfo");
        smokingPipeInfo = GameObject.Find("SmokingPipeInfo");
        woodenSpoonInfo = GameObject.Find("WoodenSpoonInfo");
        coatInfo = GameObject.Find("CoatInfo");
        */
        
        //flowerPotInfo = GameObject.Find("FlowerPotInfo");
        //flowerPotId = GameObject.Find("flowerpot??").gameObject.GetInstanceID();
        
        /*
        lampInfo.SetActive(false);
        knifeInfo.SetActive(false);
        hatInfo.SetActive(false);
        tableInfo.SetActive(false);
        metalLadleInfo.SetActive(false);
        grubHoeInfo.SetActive(false);
        gourdLadleInfo.SetActive(false);
        flowerEarthenInfo.SetActive(false);
        candleInfo.SetActive(false);
        bedInfo.SetActive(false);
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
        */
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

            if (objHeld == playerCam.GetComponent<InstanceId>().sugNipId)
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "SuggarNipperInfo")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }

            else if (objHeld == playerCam.GetComponent<InstanceId>().brownMugId)
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "BrownGlazedMugInfo")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }

            else if (objHeld == playerCam.GetComponent<InstanceId>().broomId)
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "BroomInfo")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }

            else if (objHeld == playerCam.GetComponent<InstanceId>().bucketId)
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "BucketInfo")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }

            else if (objHeld == playerCam.GetComponent<InstanceId>().pewterPlateId)
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "PewterPlateInfo")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }

            else if (objHeld == playerCam.GetComponent<InstanceId>().woodenStoolId)
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "WoodenStoolInfo")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }

            else if (objHeld == playerCam.GetComponent<InstanceId>().hornSpoonId1 || objHeld == playerCam.GetComponent<InstanceId>().hornSpoonId2 || objHeld == playerCam.GetComponent<InstanceId>().hornSpoonId3)
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "HornSpoonInfo")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }

            else if (objHeld == playerCam.GetComponent<InstanceId>().smokingPipeId)
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "SmokingPipeInfo")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }

            else if (objHeld == playerCam.GetComponent<InstanceId>().woodenSpoonId)
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "WoodenSpoonInfo")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }

            else if (objHeld == playerCam.GetComponent<InstanceId>().coatId)
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "CoatInfo")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }

            else if (objHeld == playerCam.GetComponent<InstanceId>().tableId)
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "TableInfo")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }

            else if (objHeld == playerCam.GetComponent<InstanceId>().metalLadleId)
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "MetalLadleInfo")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }

            else if (objHeld == playerCam.GetComponent<InstanceId>().lampId)
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "LampInfo")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }

            else if (objHeld == playerCam.GetComponent<InstanceId>().knifeId)
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "KnifeInfo")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }

            else if (objHeld == playerCam.GetComponent<InstanceId>().hatId)
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "HatInfo")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }

            else if (objHeld == playerCam.GetComponent<InstanceId>().grubHoeId)
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "GrubHoeInfo")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }

            else if (objHeld == playerCam.GetComponent<InstanceId>().gourdLadleId_1 || objHeld == playerCam.GetComponent<InstanceId>().gourdLadleId_2)
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "GourdLadleInfo")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }

            else if (objHeld == playerCam.GetComponent<InstanceId>().flowerEarthenId)
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "FlowerEarthInfo")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }

            else if (objHeld == playerCam.GetComponent<InstanceId>().candleId)
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "CandleInfo")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }

            else if (objHeld == playerCam.GetComponent<InstanceId>().bedId)
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "BedInfo")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }

            else
            {
                for (int i=0; i<objectInfo.Length; i++)
                {
                    if (objectInfo[i].ToString() == "InfoTemplate")
                    {
                        curOpenMenu = objectInfo[i];
                    }
                }
                curOpenMenu.SetActive(true);
            }
            
        }

        if (!playerCam.GetComponent<PickUpScript>().isHolding & menuOpen)
        {
            menuOpen = false;
            curOpenMenu.SetActive(false);
        }
    }

}

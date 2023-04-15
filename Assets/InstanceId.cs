using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceId : MonoBehaviour
{
    public int sugNipId;
    public int brownMugId;
    public int broomId;
    public int bucketId;
    public int pewterPlateId;
    public int woodenStoolId;
    public int hornSpoonId1;
    public int hornSpoonId2;
    public int hornSpoonId3;
    public int smokingPipeId;
    public int woodenSpoonId;
    public int coatId;
    public int tableId;
    public int metalLadleId;
    public int lampId;
    public int knifeId;
    public int hatId;
    public int grubHoeId;
    public int gourdLadleId_1;
    public int gourdLadleId_2;
    public int flowerEarthenId;
    public int candleId;
    public int bedId;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (tableId == 0)
        {
            tableId = GameObject.Find("Table").gameObject.GetInstanceID();
        }

        if (sugNipId == 0)
        {
            sugNipId = GameObject.Find("SugarNippers").gameObject.GetInstanceID();
        }
        
        if (metalLadleId == 0)
        {
            metalLadleId = GameObject.Find("MetalLadle").gameObject.GetInstanceID();
        }

        if (lampId == 0)
        {
            lampId = GameObject.Find("WickLamp").gameObject.GetInstanceID();
        }

        if (knifeId == 0)
        {
            knifeId = GameObject.Find("HookKnife").gameObject.GetInstanceID();
        }

        if (hatId == 0)
        {
            hatId = GameObject.Find("StrawHat").gameObject.GetInstanceID();
        }

        if (grubHoeId == 0)
        {
            grubHoeId = GameObject.Find("GrubHoe").gameObject.GetInstanceID();
        }

        if (gourdLadleId_1 == 0)
        {
            gourdLadleId_1 = GameObject.Find("GourdLadle1").gameObject.GetInstanceID();
        }

        if (gourdLadleId_2 == 0)
        {
            gourdLadleId_2 = GameObject.Find("GourdLadle2").gameObject.GetInstanceID();
        }

        if (flowerEarthenId == 0)
        {
            flowerEarthenId = GameObject.Find("flowerpot_earthern").gameObject.GetInstanceID();
        }

        if (candleId == 0)
        {
            candleId = GameObject.Find("CanldeHolder").gameObject.GetInstanceID();
        }

        if (bedId == 0)
        {
            bedId = GameObject.Find("Bed").gameObject.GetInstanceID();
        }

        if (brownMugId == 0)
        {
            brownMugId = GameObject.Find("BrownGlazedMug").gameObject.GetInstanceID();
        }

        if (broomId == 0)
        {
            broomId = GameObject.Find("Broom").gameObject.GetInstanceID();
        }

        if (bucketId == 0)
        {
            bucketId = GameObject.Find("Bucket").gameObject.GetInstanceID();
        }

        if (pewterPlateId == 0)
        {
            pewterPlateId = GameObject.Find("PewterPlate").gameObject.GetInstanceID();
        }

        if (woodenSpoonId == 0)
        {
            woodenStoolId = GameObject.Find("WoodenStool").gameObject.GetInstanceID();
        }

        if (hornSpoonId1 == 0)
        {
            hornSpoonId1 = GameObject.Find("HornSpoon1").gameObject.GetInstanceID();
        }

        if (hornSpoonId2 == 0)
        {
            hornSpoonId2 = GameObject.Find("HornSpoon2").gameObject.GetInstanceID();
        }

        if (hornSpoonId3 == 0)
        {
            hornSpoonId3 = GameObject.Find("HornSpoon3").gameObject.GetInstanceID();
        }

        if (smokingPipeId == 0)
        {
            smokingPipeId = GameObject.Find("SmokingPipe").gameObject.GetInstanceID();
        }

        if (woodenSpoonId == 0)
        {
            woodenSpoonId = GameObject.Find("WoodenSpoon").gameObject.GetInstanceID();
        }

        if (coatId == 0)
        {
            coatId = GameObject.Find("Coat").gameObject.GetInstanceID();
        }

    }
}

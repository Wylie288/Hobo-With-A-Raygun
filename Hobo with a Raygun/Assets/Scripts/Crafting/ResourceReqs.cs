using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceReqs : MonoBehaviour
{
    public Text P;
    public Text S;
    public Text T;
    public Text Q;
    public Text Name;

    void Update()
    {
        if (Name.text == "Health A")
        {
            P.text = CraftingData.getDataP(0,0).ToString();
            S.text = CraftingData.getDataS(0,0).ToString();
            T.text = CraftingData.getDataT(0,0).ToString();
            Q.text = CraftingData.getDataQ(0,0).ToString();
        }

        if (Name.text == "Health B")
        {
            P.text = CraftingData.getDataP(0,1).ToString();
            S.text = CraftingData.getDataS(0,1).ToString();
            T.text = CraftingData.getDataT(0,1).ToString();
            Q.text = CraftingData.getDataQ(0,1).ToString();
        }

        if (Name.text == "Health C")
        {
            P.text = CraftingData.getDataP(0,2).ToString();
            S.text = CraftingData.getDataS(0,2).ToString();
            T.text = CraftingData.getDataT(0,2).ToString();
            Q.text = CraftingData.getDataQ(0,2).ToString();
        }
        if (Name.text == "Mining Laser MKI A")
        {
            P.text = CraftingData.getDataP(1,0).ToString();
            S.text = CraftingData.getDataS(1,0).ToString();
            T.text = CraftingData.getDataT(1,0).ToString();
            Q.text = CraftingData.getDataQ(1,0).ToString();
        }
        if (Name.text == "Mining Laser MKI B")
        {
            P.text = CraftingData.getDataP(1,1).ToString();
            S.text = CraftingData.getDataS(1,1).ToString();
            T.text = CraftingData.getDataT(1,1).ToString();
            Q.text = CraftingData.getDataQ(1,1).ToString();
        }
        if (Name.text == "Mining Laser MKI C")
        {
            P.text = CraftingData.getDataP(1,2).ToString();
            S.text = CraftingData.getDataS(1,2).ToString();
            T.text = CraftingData.getDataT(1,2).ToString();
            Q.text = CraftingData.getDataQ(1,2).ToString();
        }
        if (Name.text == "Mining Laser MKII A")
        {
            P.text = CraftingData.getDataP(2,0).ToString();
            S.text = CraftingData.getDataS(2,0).ToString();
            T.text = CraftingData.getDataT(2,0).ToString();
            Q.text = CraftingData.getDataQ(2,0).ToString();
        }
        if (Name.text == "Mining Laser MKII B")
        {
            P.text = CraftingData.getDataP(2,1).ToString();
            S.text = CraftingData.getDataS(2,1).ToString();
            T.text = CraftingData.getDataT(2,1).ToString();
            Q.text = CraftingData.getDataQ(2,1).ToString();
        }
        if (Name.text == "Mining Laser MKII C")
        {
            P.text = CraftingData.getDataP(2,2).ToString();
            S.text = CraftingData.getDataS(2,2).ToString();
            T.text = CraftingData.getDataT(2,2).ToString();
            Q.text = CraftingData.getDataQ(2,2).ToString();
        }
        if (Name.text == "Blaster A")
        {
            P.text = CraftingData.getDataP(3,0).ToString();
            S.text = CraftingData.getDataS(3,0).ToString();
            T.text = CraftingData.getDataT(3,0).ToString();
            Q.text = CraftingData.getDataQ(3,0).ToString();
        }
        if (Name.text == "Blaster B")
        {
            P.text = CraftingData.getDataP(3,1).ToString();
            S.text = CraftingData.getDataS(3,1).ToString();
            T.text = CraftingData.getDataT(3,1).ToString();
            Q.text = CraftingData.getDataQ(3,1).ToString();
        }
        if (Name.text == "Blaster C")
        {
            P.text = CraftingData.getDataP(3,2).ToString();
            S.text = CraftingData.getDataS(3,2).ToString();
            T.text = CraftingData.getDataT(3,2).ToString();
            Q.text = CraftingData.getDataQ(3,2).ToString();
        }
    }
}

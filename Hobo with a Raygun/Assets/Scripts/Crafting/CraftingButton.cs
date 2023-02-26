using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingButton : MonoBehaviour
{
    private int P;
    private int S;
    private int T;
    private int Q;
    public GameObject UI;
    public Text Name;

    public void Craft()
    {
        if (UI.GetComponent<ResourceInput>().cp >= P)
            if (UI.GetComponent<ResourceInput>().cs >= S)
                if (UI.GetComponent<ResourceInput>().ct >= T)
                    if (UI.GetComponent<ResourceInput>().cq >= Q)
                    {
                        UI.GetComponent<ResourceInput>().cp -= P;
                        UI.GetComponent<ResourceInput>().cs -= S;
                        UI.GetComponent<ResourceInput>().ct -= T;
                        UI.GetComponent<ResourceInput>().cq -= Q;

                        if (Name.text == "Blaster A")
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(5);
                        if (Name.text == "Blaster B")
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(6);
                        if (Name.text == "Blaster C")
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(7);

                        if (Name.text == "Health A")
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(8);
                        if (Name.text == "Health B")
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(9);
                        if (Name.text == "Health C")
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(10);

                        if (Name.text == "Mining Laser MKI A")
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(11);
                        if (Name.text == "Mining Laser MKI B")
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(12);
                        if (Name.text == "Mining Laser MKI C")
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(13);

                        if (Name.text == "Mining Laser MKII A")
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(14);
                        if (Name.text == "Mining Laser MKII B")
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(15);
                        if (Name.text == "Mining Laser MKII V")
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(16);
                    }
    }

    void Update()
    {
        if (Name.text == "Health A")
        {
            P = CraftingData.getDataP(0,0);
            S = CraftingData.getDataS(0,0);
            T = CraftingData.getDataT(0,0);
            Q = CraftingData.getDataQ(0,0);
        }

        if (Name.text == "Health B")
        {
            P = CraftingData.getDataP(0,1);
            S = CraftingData.getDataS(0,1);
            T = CraftingData.getDataT(0,1);
            Q = CraftingData.getDataQ(0,1);
        }

        if (Name.text == "Health C")
        {
            P = CraftingData.getDataP(0,2);
            S = CraftingData.getDataS(0,2);
            T = CraftingData.getDataT(0,2);
            Q = CraftingData.getDataQ(0,2);
        }
        if (Name.text == "Mining Laser MKI A")
        {
            P = CraftingData.getDataP(1,0);
            S = CraftingData.getDataS(1,0);
            T = CraftingData.getDataT(1,0);
            Q = CraftingData.getDataQ(1,0);
        }
        if (Name.text == "Mining Laser MKI B")
        {
            P = CraftingData.getDataP(1,1);
            S = CraftingData.getDataS(1,1);
            T = CraftingData.getDataT(1,1);
            Q = CraftingData.getDataQ(1,1);
        }
        if (Name.text == "Mining Laser MKI C")
        {
            P = CraftingData.getDataP(1,2);
            S = CraftingData.getDataS(1,2);
            T = CraftingData.getDataT(1,2);
            Q = CraftingData.getDataQ(1,2);
        }
        if (Name.text == "Mining Laser MKII A")
        {
            P = CraftingData.getDataP(2,0);
            S = CraftingData.getDataS(2,0);
            T = CraftingData.getDataT(2,0);
            Q = CraftingData.getDataQ(2,0);
        }
        if (Name.text == "Mining Laser MKII B")
        {
            P = CraftingData.getDataP(2,1);
            S = CraftingData.getDataS(2,1);
            T = CraftingData.getDataT(2,1);
            Q = CraftingData.getDataQ(2,1);
        }
        if (Name.text == "Mining Laser MKII C")
        {
            P = CraftingData.getDataP(2,2);
            S = CraftingData.getDataS(2,2);
            T = CraftingData.getDataT(2,2);
            Q = CraftingData.getDataQ(2,2);
        }
        if (Name.text == "Blaster A")
        {
            P = CraftingData.getDataP(3,0);
            S = CraftingData.getDataS(3,0);
            T = CraftingData.getDataT(3,0);
            Q = CraftingData.getDataQ(3,0);
        }
        if (Name.text == "Blaster B")
        {
            P = CraftingData.getDataP(3,1);
            S = CraftingData.getDataS(3,1);
            T = CraftingData.getDataT(3,1);
            Q = CraftingData.getDataQ(3,1);
        }
        if (Name.text == "Blaster C")
        {
            P = CraftingData.getDataP(3,2);
            S = CraftingData.getDataS(3,2);
            T = CraftingData.getDataT(3,2);
            Q = CraftingData.getDataQ(3,2);
        }
    }
}

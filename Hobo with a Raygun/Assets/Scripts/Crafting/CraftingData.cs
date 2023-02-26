using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingData : MonoBehaviour
{
    static public int[,,] mats;

    static public int getDataP(int a, int b)
    {
        setData();
        return mats[a,b,0];
    }

    static public int getDataS(int a, int b)
    {
        setData();
        return mats[a,b,1];
    }

    static public int getDataT(int a, int b)
    {
        setData();
        return mats[a,b,2];
    }

    static public int getDataQ(int a, int b)
    {
        setData();
        return mats[a,b,3];
    }

    static void setData()
    {
        mats = new int[4,3,4];

        //Health
        mats[0,0,0] = 2;
        mats[0,0,1] = 2;
        mats[0,0,2] = 0;
        mats[0,0,3] = 0;

        mats[0,1,0] = 0;
        mats[0,1,1] = 0;
        mats[0,1,2] = 3;
        mats[0,1,3] = 0;

        mats[0,2,0] = 0;
        mats[0,2,1] = 2;
        mats[0,2,2] = 1;
        mats[0,2,3] = 1;

        //Mining 1
        mats[1,0,0] = 2;
        mats[1,0,1] = 0;
        mats[1,0,2] = 0;
        mats[1,0,3] = 0;

        mats[1,1,0] = 1;
        mats[1,1,1] = 2;
        mats[1,1,2] = 1;
        mats[1,1,3] = 0;

        mats[1,2,0] = 0;
        mats[1,2,1] = 0;
        mats[1,2,2] = 0;
        mats[1,2,3] = 1;

        //Mining 2
        mats[2,0,0] = 4;
        mats[2,0,1] = 0;
        mats[2,0,2] = 0;
        mats[2,0,3] = 0;

        mats[2,1,0] = 2;
        mats[2,1,1] = 0;
        mats[2,1,2] = 2;
        mats[2,1,3] = 0;

        mats[2,2,0] = 0;
        mats[2,2,1] = 2;
        mats[2,2,2] = 2;
        mats[2,2,3] = 0;

        //Blaster
        mats[3,0,0] = 0;
        mats[3,0,1] = 2;
        mats[3,0,2] = 0;
        mats[3,0,3] = 0;

        mats[3,1,0] = 1;
        mats[3,1,1] = 1;
        mats[3,1,2] = 2;
        mats[3,1,3] = 0;

        mats[3,2,0] = 0;
        mats[3,2,1] = 2;
        mats[3,2,2] = 1;
        mats[3,2,3] = 1;
    }
}

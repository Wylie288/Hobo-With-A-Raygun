using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrFoodData : MonoBehaviour
{
    static public float[,,] food;
    static public float scale;

    static public float getTime(int c, int p)
    {
        setFood();
        return food[c,p,0];
    }

    static public float getReplenish(int c, int p)
    {
        setFood();
        return food[c,p,1];
    }

    static void setFood()
    {
        float scale = 1;
        food = new float[5,5,4];
        //Carbon, Phosphotus, id
        //id 0 = time
        //id 1 = replenish
        //id 2 = special id -1 if no special
        //id 3 = poison

        //Fruit
        food[0,0,0] = 100 / scale;
        food[0,0,1] = .075f;
        food[0,0,2] = -1;
        food[0,0,3] = 0;

        //Fruit C1
        food[1,0,0] = 130 / scale;
        food[1,0,1] = .075f;
        food[1,0,2] = 1;
        food[1,0,3] = 0;

        //Fruit P1
        food[0,1,0] = 100 / scale;
        food[0,1,1] = .12f;
        food[0,1,2] = 2;
        food[0,1,3] = 0;

        //Fruit C1P1
        food[1,1,0] = 200 / scale;
        food[1,1,1] = .20f;
        food[1,1,2] = -1;
        food[1,1,3] = 0;

        //Fruit C2P1
        food[2,1,0] = 230 / scale;
        food[2,1,1] = .20f;
        food[2,1,2] = 3;
        food[2,1,3] = 0;

        //Fruit C1P2
        food[1,2,0] = 200 / scale;
        food[1,2,1] = .28f;
        food[1,2,2] = 4;
        food[1,2,3] = 0;

        //Fruit C2P2
        food[2,2,0] = 300 / scale;
        food[2,2,1] = .35f;
        food[2,2,2] = -1;
        food[2,2,3] = 0;

        //Fruit C3P2
        food[3,2,0] = 330 / scale;
        food[3,2,1] = .35f;
        food[3,2,2] = 5;
        food[3,2,3] = 0;

        //Fruit C2P3
        food[2,3,0] = 300 / scale;
        food[2,3,1] = .43f;
        food[2,3,2] = 6;
        food[2,3,3] = 0;

        //Fruit C3P3
        food[3,3,0] = 400 / scale;
        food[3,3,1] = .55f;
        food[3,3,2] = -1;
        food[3,3,3] = 0;

        //Fruit C4P3
        food[4,3,0] = 430 / scale;
        food[4,3,1] = .55f;
        food[4,3,2] = 7;
        food[4,3,3] = 0;

        //Fruit C3P4
        food[3,4,0] = 400 / scale;
        food[3,4,1] = .70f;
        food[3,4,2] = 8;
        food[3,4,3] = 0;

        //Fruit C4P4
        food[4,4,0] = 500 / scale;
        food[4,4,1] = .85f;
        food[4,4,2] = -1;
        food[4,4,3] = 0;
    }
}

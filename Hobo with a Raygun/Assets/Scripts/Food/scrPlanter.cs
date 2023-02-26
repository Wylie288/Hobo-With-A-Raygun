using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrPlanter : scrPlanterGeneric
{
    public int c;
    public int p;
    public GameObject planterEmpty;
    public Sprite sprHalf;
    public Sprite sprFull2;
    public Sprite sprFull3;

    void Start()
    {
        Init(c, p);
    }
	
	void FixedUpdate()
    {
         Fixed(sprHalf, sprFull2, sprFull3);
    }

    void OnMouseOver()
        {
            Mouse(planterEmpty, c, p);
        }
}

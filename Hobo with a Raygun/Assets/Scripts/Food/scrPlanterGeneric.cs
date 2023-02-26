using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrPlanterGeneric : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    public float growth = 0;
    private float growTime = 1;
    private float stage = -1;
    private int fruits;
    
    public void Init(int c2, int p2)
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        growTime = scrFoodData.getTime(c2,p2);
        stage = 0;
    }

    public void Fixed(Sprite sprH, Sprite sprF2, Sprite sprF3)
    {
        if ((stage > -1) && (growth < 1))
        {
            growth += Time.deltaTime / (growTime) * (100/60);

            if (growth > 1)
                growth = 1;

            if ((growth >= .5) && (stage == 0))
            {
                stage = 1;
                sr.sprite = sprH;
            }

            if ((growth == 1) && (stage == 1))
            {
                stage = 2;
                fruits = Random.Range(2,4);
                if (fruits == 2)
                    sr.sprite = sprF2;
                if (fruits == 3)
                    sr.sprite = sprF3;
            }
        }      
    }

    public void Mouse(GameObject empty, int c2, int p2)
    {
        if (Input.GetMouseButtonDown(0))
            {
                if ((c2 == 0) && (p2 == 0))
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(100);
                    if (stage == 2)
                    {
                        if (fruits == 2)
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(100);
                        if (fruits == 3)
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(100);
                    }
                }
                if ((c2 == 1) && (p2 == 0))
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(110);
                    if (stage == 2)
                    {
                        if (fruits == 2)
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(110);
                        if (fruits == 3)
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(110);
                    }
                }
                if ((c2 == 0) && (p2 == 1))
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(101);
                    if (stage == 2)
                    {
                        if (fruits == 2)
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(101);
                        if (fruits == 3)
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(101);
                    }
                }
                if ((c2 == 1) && (p2 == 1))
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(111);
                    if (stage == 2)
                    {
                        if (fruits == 2)
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(111);
                        if (fruits == 3)
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(11);
                    }
                }
                if ((c2 == 2) && (p2 == 2))
                {
                    GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(122);
                    if (stage == 2)
                    {
                        if (fruits == 2)
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(122);
                        if (fruits == 3)
                            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(122);
                    }
                }
                Instantiate(empty,new Vector3(rb.position.x,rb.position.y),Quaternion.identity);
                Destroy(this.gameObject);
            }
    }

    
}

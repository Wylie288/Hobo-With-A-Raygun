using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrPlayerHunger : MonoBehaviour
{
    //Hunger
    public float hungerSeconds; //Seconds to hunger depletion
    /*[HideInInspector]*/public float hunger; //Hunger percentage
    public Text hungerGUI; //Hunger GUI
    public GameObject blindness;

    void Start()
    {
        hunger = 1;
    }

    void Update()
    {
    }

    void FixedUpdate()
    {
        //Hunger
        hunger = passiveStatus(hunger, hungerSeconds);
        if (hunger > 1)
            hunger = 1;
        hungerGUI.text = "Hunger: " + Mathf.Round(hunger * 100) + "%";

        invCheck();
        /* if (Input.GetKeyDown (KeyCode.E))
        {
            hunger += scrFoodData.getReplenish(3,3);

            if (hunger > 1)
                hunger = 1;
        }*/
    }

    float passiveStatus(float status, float seconds) //Hunger decreasing
    {
        if (status > 0)
            status -= Time.deltaTime / (seconds) * (100/60);
        else
            status = 0;

        return status;
    }

    void invCheck()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            int active = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Slot>().active;
            Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

            if (GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().characterItems.Count >= active + 1)
            {
                if (inventory.ItemAt(active).id > 99)
                {
                    int c = inventory.ItemAt(active).stats["C"];
                    int p = inventory.ItemAt(active).stats["P"];
                    GameObject.FindGameObjectWithTag("Player").GetComponent<scrPlayerHunger>().hunger += scrFoodData.getReplenish(c,p);
                    inventory.RemoveItem(inventory.ItemAt(active).id);

                    if ((c == 1) && (p == 0))
                       GameObject.FindGameObjectWithTag("Player").GetComponent<scrPlayerHealth>().health += 5;
                    if ((c == 0) && (p == 1))
                        Instantiate(blindness,new Vector3(0,0,100),Quaternion.identity);
                    if ((c == 2) && (p == 2))
                       GameObject.FindGameObjectWithTag("Player").GetComponent<scrPlayerHealth>().health -= 75;
                }
            }
        }
    }
}

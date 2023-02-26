using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceInput : MonoBehaviour
{
    public Text tp;
    public Text ts;
    public Text tt;
    public Text tq;
    public int cp;
    public int cs;
    public int ct;
    public int cq;
    private Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tp.text = cp.ToString();;
        ts.text = cs.ToString();;
        tt.text = ct.ToString();;
        tq.text = cq.ToString();;
    }

    public void addP()
    {
        Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); 
        int active = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Slot>().active;
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().characterItems.Count >= active + 1)
        {
            if (inventory.CheckForItem(1).id == 1)
            {
                cp += 1;
                inventory.RemoveItem(1);
            }
        }
    }
    public void addS()
    {
        Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); 
        int active = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Slot>().active;
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().characterItems.Count >= active + 1)
        {
            if (inventory.CheckForItem(2).id == 2)
            {
                cs += 1;
                inventory.RemoveItem(2);
            }
        }
    }
    public void addT()
    {
        Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); 
        int active = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Slot>().active;
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().characterItems.Count >= active + 1)
        {
            if (inventory.CheckForItem(3).id == 3)
            {
                ct += 1;
                inventory.RemoveItem(3);
            }
        }
    }
    public void addQ()
    {
        Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); 
        int active = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Slot>().active;
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().characterItems.Count >= active + 1)
        {
            if (inventory.CheckForItem(4).id == 4)
            {
                cq += 1;
                inventory.RemoveItem(4);
            }
        }
    }
    public void removeP()
    {
        if (cp >= 1)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(1);
            cp -= 1;
        }
    }
    public void removeS()
    {
        if (cs >= 1)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(2);
            cs -= 1;
        }
    }
    public void removeT()
    {
        if (ct >= 1)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(3);
            ct -= 1;
        }
    }
    public void removeQ()
    {
        if (cq >= 1)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(4);
            cq -= 1;
        }
    }
}

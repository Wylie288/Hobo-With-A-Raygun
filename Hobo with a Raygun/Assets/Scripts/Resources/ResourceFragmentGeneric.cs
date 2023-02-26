using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceFragmentGeneric : MonoBehaviour
{
    public int pos;
    public GameObject node;
    public int invName;
    public int laser;
    private void OnMouseOver()
    {
         if (Input.GetMouseButtonDown(0))
            {
                item();
            }
    }

    public void collect()
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(invName);
        node.GetComponent<resourceGeneric>().removeNode(pos);
        Destroy(this.gameObject);
    }

    private void item()
    {
        int active = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Slot>().active;
        Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().characterItems.Count >= active + 1)
        {
            if (laser == 1)
            {
                if (inventory.ItemAt(active).id == 11)
                {
                    inventory.ItemAt(active).stats["mine"] -= 1;
                    if (inventory.ItemAt(active).stats["mine"] == 0)
                        inventory.RemoveItem(11);

                    collect();
                }
                else if (inventory.ItemAt(active).id == 12)
                {
                    inventory.ItemAt(active).stats["mine"] -= 1;
                    if (inventory.ItemAt(active).stats["mine"] == 0)
                        inventory.RemoveItem(12);

                    collect();
                } 
                else if (inventory.ItemAt(active).id == 13)
                {
                    inventory.ItemAt(active).stats["mine"] -= 1;
                    if (inventory.ItemAt(active).stats["mine"] == 0)
                        inventory.RemoveItem(13);

                    collect();
                } 
            }
            else if (laser == 2)
            {
                if (inventory.ItemAt(active).id == 14)
                {
                    inventory.ItemAt(active).stats["mine"] -= 1;
                    if (inventory.ItemAt(active).stats["mine"] == 0)
                        inventory.RemoveItem(14);

                    collect();
                }
                else if (inventory.ItemAt(active).id == 15)
                {
                    inventory.ItemAt(active).stats["mine"] -= 1;
                    if (inventory.ItemAt(active).stats["mine"] == 0)
                        inventory.RemoveItem(15);

                    collect();
                } 
                else if (inventory.ItemAt(active).id == 16)
                {
                    inventory.ItemAt(active).stats["mine"] -= 1;
                    if (inventory.ItemAt(active).stats["mine"] == 0)
                        inventory.RemoveItem(16);

                    collect();
                } 
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrPlanterEmpty : MonoBehaviour
{
    public GameObject planter00;
    public GameObject planter10;
    public GameObject planter01;
    public GameObject planter11;
    public GameObject planter22;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMouseOver()
        {
            if (Input.GetMouseButtonDown(1))
            {
                int active = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Slot>().active;
                Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

                if (GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().characterItems.Count >= active + 1)
                {
                    if (inventory.ItemAt(active).id == 100)
                    {
                        inventory.RemoveItem(100);
                        Instantiate(planter00,new Vector3(rb.position.x,rb.position.y),Quaternion.identity);
                        Destroy(this.gameObject);
                    }
                    else if (inventory.ItemAt(active).id == 110)
                    {
                        inventory.RemoveItem(110);
                        Instantiate(planter10,new Vector3(rb.position.x,rb.position.y),Quaternion.identity);
                        Destroy(this.gameObject);
                    }
                    else if (inventory.ItemAt(active).id == 101)
                    {
                        inventory.RemoveItem(101);
                        Instantiate(planter01,new Vector3(rb.position.x,rb.position.y),Quaternion.identity);
                        Destroy(this.gameObject);
                    }
                    else if (inventory.ItemAt(active).id == 111)
                    {
                        inventory.RemoveItem(111);
                        Instantiate(planter11,new Vector3(rb.position.x,rb.position.y),Quaternion.identity);
                        Destroy(this.gameObject);
                    }
                    else if (inventory.ItemAt(active).id == 122)
                    {
                        inventory.RemoveItem(122);
                        Instantiate(planter22,new Vector3(rb.position.x,rb.position.y),Quaternion.identity);
                        Destroy(this.gameObject);
                    }
                }
                
            }
        }
}

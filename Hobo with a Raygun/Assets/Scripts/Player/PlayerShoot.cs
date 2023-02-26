using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject laser;
    
    public float laserSpeed;
    private Vector3 mousePosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        fire();
    }

    private void fire()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            int active = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Slot>().active;
            Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

            if (GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().characterItems.Count >= active + 1)
            {
                if (inventory.ItemAt(active).id == 5)
                {
                    inventory.ItemAt(active).stats["shots"] -= 1;
                    if (inventory.ItemAt(active).stats["shots"] == 0)
                        inventory.RemoveItem(5);

                    GameObject shootLaser = (GameObject)Instantiate(laser, transform.position, this.transform.rotation);
                    shootLaser.GetComponent<Rigidbody2D>().velocity = (mousePosition - transform.position).normalized * laserSpeed;
                }
                else if (inventory.ItemAt(active).id == 6)
                {
                    inventory.ItemAt(active).stats["shots"] -= 1;
                    if (inventory.ItemAt(active).stats["shots"] == 0)
                        inventory.RemoveItem(6);

                    GameObject shootLaser = (GameObject)Instantiate(laser, transform.position, this.transform.rotation);
                    shootLaser.GetComponent<Rigidbody2D>().velocity = (mousePosition - transform.position).normalized * laserSpeed;
                } 
                else if (inventory.ItemAt(active).id == 7)
                {
                    inventory.ItemAt(active).stats["shots"] -= 1;
                    if (inventory.ItemAt(active).stats["shots"] == 0)
                        inventory.RemoveItem(7);

                    GameObject shootLaser = (GameObject)Instantiate(laser, transform.position, this.transform.rotation);
                    shootLaser.GetComponent<Rigidbody2D>().velocity = (mousePosition - transform.position).normalized * laserSpeed;
                } 
            }
        }
    }
}
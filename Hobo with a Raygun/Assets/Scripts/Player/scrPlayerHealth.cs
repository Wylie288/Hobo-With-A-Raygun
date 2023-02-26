using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrPlayerHealth : MonoBehaviour
{
    private float MAX_HEALTH = 100.0F;
    public float health;
    public Text healthGUI;
    public scrPlayerHunger ph;
    public scrOxygone oh;
    // Start is called before the first frame update
    void Start()
    {
        health = MAX_HEALTH;
        ph = GetComponent<scrPlayerHunger>();
        oh = GetComponent<scrOxygone>();
    }

    // Update is called once per frame
    void Update()
    {
        healthGUI.text = "Health: " + Mathf.Round(health) + "%";
        if(ph.hunger <= 0)
        {
            Invoke("HungerDamage", 1.0f);
        }
        if(oh.oxygen <= 0)
        {
            Invoke("OxygenDamage", 1.0f);
        }

        if (health <= 0)
            Destroy(gameObject);

        HealthPack();
    }

    public void Heal(float heal)
    {
        health += heal;
        if (health > 100.0F)
            health = 100.0F;
    }

    public void TakeDamage(float damage)
    {
        health = health - damage;
    }
    public void HungerDamage()
    {
        health = health - 5;
        CancelInvoke("HungerDamage");
    }
    public void OxygenDamage()
    {
        health = health - 5;
        CancelInvoke("OxygenDamage");
    }

    public void HealthPack()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            int active = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Slot>().active;
            Inventory inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

            if (GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().characterItems.Count >= active + 1)
            {
                if (inventory.ItemAt(active).id == 8)
                {
                    Heal(inventory.ItemAt(active).stats["health"]);
                    inventory.RemoveItem(8);
                }
                if (inventory.ItemAt(active).id == 9)
                {
                    Heal(inventory.ItemAt(active).stats["health"]);
                    inventory.RemoveItem(9);
                }
                if (inventory.ItemAt(active).id == 10)
                {
                    Heal(inventory.ItemAt(active).stats["health"]);
                    inventory.RemoveItem(10);
                }
            }
        }
    }
}

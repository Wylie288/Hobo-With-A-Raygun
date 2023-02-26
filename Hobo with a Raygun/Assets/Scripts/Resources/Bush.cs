using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bush : MonoBehaviour
{
    public GameObject empty;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(100);
            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(100);
            GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().GiveItem(100);
            Instantiate(empty,new Vector3(rb.position.x,rb.position.y),Quaternion.identity);
                Destroy(this.gameObject);
        }
    }
}

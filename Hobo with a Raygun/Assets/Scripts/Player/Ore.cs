using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore : MonoBehaviour
{
    public Mining m;
    // Start is called before the first frame update
    void Start()
    {
        m = GameObject.FindObjectOfType<Mining>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("Enter");
        if(coll.gameObject == GameObject.FindGameObjectWithTag("MineTool"))
        {
            m.Invoke("Collect", 1.0f);
        }
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if(coll.gameObject == GameObject.FindGameObjectWithTag("MineTool"))
        {
            m.Invoke("Collect", 1.0f);
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        Debug.Log("Exit");
        if(coll.gameObject == GameObject.FindGameObjectWithTag("MineTool"))
        {
            m.CancelInvoke("Collect");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mining : MonoBehaviour
{
    public GameObject tool;
    public int rcount;
    public Text rtext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            tool.SetActive(true);
        }
        else
            tool.SetActive(false);
        rtext.text = "Resource Count: " + rcount;
    }
    public void Collect()
    {
        rcount += 1;
        CancelInvoke("Collect");
    }
}

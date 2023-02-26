using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    private int slotN;
    public GameObject imageObject1;
    public GameObject imageObject2;
    public GameObject imageObject3;
    public GameObject imageObject4;
    public GameObject imageObject5;
    public GameObject imageObject6;
    public GameObject imageObject7;
    public GameObject imageObject8;
    public GameObject imageObject9;
    public GameObject slotObject1;
    public GameObject slotObject2;
    public GameObject slotObject3;
    public GameObject slotObject4;
    public GameObject slotObject5;
    public GameObject slotObject6;
    public GameObject slotObject7;
    public GameObject slotObject8;
    public GameObject slotObject9;
    private Image image;
    public int active = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Alpha1))
            active = 0;
        if (Input.GetKeyDown (KeyCode.Alpha2))
            active = 1;
        if (Input.GetKeyDown (KeyCode.Alpha3))
            active = 2;
        if (Input.GetKeyDown (KeyCode.Alpha4))
            active = 3;
        if (Input.GetKeyDown (KeyCode.Alpha5))
            active = 4;
        if (Input.GetKeyDown (KeyCode.Alpha6))
            active = 5;
        if (Input.GetKeyDown (KeyCode.Alpha7))
            active = 6;
        if (Input.GetKeyDown (KeyCode.Alpha8))
            active = 7;
        if (Input.GetKeyDown (KeyCode.Alpha9))
            active = 8;

        image = imageObject1.GetComponent<Image>();
            slotN = 1;
            updateImage();
        image = imageObject2.GetComponent<Image>();
            slotN = 2;
            updateImage();
        image = imageObject3.GetComponent<Image>();
            slotN = 3;
            updateImage();
        image = imageObject4.GetComponent<Image>();
            slotN = 4;
            updateImage();
        image = imageObject5.GetComponent<Image>();
            slotN = 5;
            updateImage();
        image = imageObject6.GetComponent<Image>();
            slotN = 6;
            updateImage();
        image = imageObject7.GetComponent<Image>();
            slotN = 7;
            updateImage();
        image = imageObject8.GetComponent<Image>();
            slotN = 8;
            updateImage();
        image = imageObject9.GetComponent<Image>();
            slotN = 9;
            updateImage();

        image = slotObject1.GetComponent<Image>();
            image.color = new Color32(255,255,225,100);
        image = slotObject2.GetComponent<Image>();
            image.color = new Color32(255,255,225,100);
        image = slotObject3.GetComponent<Image>();
            image.color = new Color32(255,255,225,100);
        image = slotObject4.GetComponent<Image>();
            image.color = new Color32(255,255,225,100);
        image = slotObject5.GetComponent<Image>();
            image.color = new Color32(255,255,225,100);
        image = slotObject6.GetComponent<Image>();
            image.color = new Color32(255,255,225,100);
        image = slotObject7.GetComponent<Image>();
            image.color = new Color32(255,255,225,100);
        image = slotObject8.GetComponent<Image>();
            image.color = new Color32(255,255,225,100);
        image = slotObject9.GetComponent<Image>();
            image.color = new Color32(255,255,225,100);

        if (active == 0)
        {
            image = slotObject1.GetComponent<Image>();
            image.color = new Color32(255,0,0,100);
        }
        if (active == 1)
        {
            image = slotObject2.GetComponent<Image>();
            image.color = new Color32(255,0,0,100);
        }
        if (active == 2)
        {
            image = slotObject3.GetComponent<Image>();
            image.color = new Color32(255,0,0,100);
        }
        if (active == 3)
        {
            image = slotObject4.GetComponent<Image>();
            image.color = new Color32(255,0,0,100);
        }
        if (active == 4)
        {
            image = slotObject5.GetComponent<Image>();
            image.color = new Color32(255,0,0,100);
        }
        if (active == 5)
        {
            image = slotObject6.GetComponent<Image>();
            image.color = new Color32(255,0,0,100);
        }
        if (active == 6)
        {
            image = slotObject7.GetComponent<Image>();
            image.color = new Color32(255,0,0,100);
        }
        if (active == 7)
        {
            image = slotObject8.GetComponent<Image>();
            image.color = new Color32(255,0,0,100);
        }
        if (active == 8)
        {
            image = slotObject9.GetComponent<Image>();
            image.color = new Color32(255,0,0,100);
        }

    }

    void updateImage()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().characterItems.Count >= slotN)
            image.sprite = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>().ItemAt(slotN - 1).icon;
        else
            image.sprite = Resources.Load<Sprite>("Empty");
            

    }
}

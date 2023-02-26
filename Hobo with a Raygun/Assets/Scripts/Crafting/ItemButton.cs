using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    public GameObject Health;
    public GameObject Mine1;
    public GameObject Mine2;
    public GameObject Blaster;
    public GameObject UI;
    public Text Name;
    public int selected = 1;


    public void resetColor()
    {
        UI.GetComponent<GradeButton>().selectA();
        Image image = Health.GetComponent<Image>();
        image.color = new Color32(255,255,255,100);
        image = Mine2.GetComponent<Image>();
        image.color = new Color32(255,255,255,100);
        image = Mine1.GetComponent<Image>();
        image.color = new Color32(255,255,255,100);
        image = Blaster.GetComponent<Image>();
        image.color = new Color32(255,255,255,100);
    }

    public void selectH()
    {
        selected = 1;
        Name.text = "Health A";
        resetColor();
        Image image = Health.GetComponent<Image>();
        image.color = new Color32(255,00,00,100);
    }
    
    public void selectM1()
    {
        selected = 2;
        Name.text = "Mining Laser MKI A";
        resetColor();
        Image image = Mine1.GetComponent<Image>();
        image.color = new Color32(255,00,00,100);
    }

    public void selectM2()
    {
        selected = 3;
        Name.text = "Mining Laser MKII A";
        resetColor();
        Image image = Mine2.GetComponent<Image>();
        image.color = new Color32(255,00,00,100);
    }

    public void selectB()
    {
        selected = 4;
        Name.text = "Blaster A";
        resetColor();
        Image image = Blaster.GetComponent<Image>();
        image.color = new Color32(255,00,00,100);
    }
}

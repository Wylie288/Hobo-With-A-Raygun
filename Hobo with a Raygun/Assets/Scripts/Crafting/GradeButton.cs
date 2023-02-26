using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GradeButton : MonoBehaviour
{
    public GameObject A;
    public GameObject B;
    public GameObject C;
    public GameObject UI;
    public Text Name;


    public void resetColor()
    {
        
        Image image = A.GetComponent<Image>();
        image.color = new Color32(255,255,255,100);
        image = B.GetComponent<Image>();
        image.color = new Color32(255,255,255,100);
        image = C.GetComponent<Image>();
        image.color = new Color32(255,255,255,100);
    }

    public string part1()
    {
        int n = UI.GetComponent<ItemButton>().selected;
        if (n == 1)
            return "Health ";
        if (n == 2)
            return "Mining Laser MKI ";
        if (n == 3)
            return "Mining Laser MKII ";
        if (n == 4)
            return "Blaster ";
        return "";
    }

    public void selectA()
    {
        string p1 = part1();
        Name.text = p1 + "A";
        resetColor();
        Image image = A.GetComponent<Image>();
        image.color = new Color32(255,00,00,100);
    }
    
    public void selectB()
    {
        string p1 = part1();
        Name.text = p1 + "B";
        resetColor();
        Image image = B.GetComponent<Image>();
        image.color = new Color32(255,00,00,100);
    }

    public void selectC()
    {
        string p1 = part1();
        Name.text = p1 + "C";
        resetColor();
        Image image = C.GetComponent<Image>();
        image.color = new Color32(255,00,00,100);
    }
}


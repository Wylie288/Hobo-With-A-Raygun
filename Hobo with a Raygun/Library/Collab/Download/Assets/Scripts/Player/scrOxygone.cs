using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrOxygone : MonoBehaviour
{
    //Oxygen
    public float oxygenSeconds; //Seconds to Oxygen depletion
    public float oxygen; //Oxygen percentage /*[HideInInspector]*/
    public int inBase;
    public Text oxygenGUI; //Oxygen GUI

   public void Start()
    {
        oxygen = 1;
        inBase = 1;
    }

     public void FixedUpdate()
    {
        if (inBase == 1)
            oxygen = 1;

        if (inBase == 0)
            oxygen = passiveBreath(oxygen, oxygenSeconds);
        
        oxygenGUI.text = "Oxygen: " + Mathf.Round(oxygen * 100) + "%";
    }

    public void setBase(int inside)
    {
        inBase = inside;
    }


  public float passiveBreath(float status, float seconds) //Oxygen decreasing
    {
        if (status > 0)
            status -= Time.deltaTime / (seconds) * (100/60);
        else
            status = 0;

        return status;
    }
  
}

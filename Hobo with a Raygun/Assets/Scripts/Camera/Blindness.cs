using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blindness : MonoBehaviour
{
    float blindness = 1;
    // Update is called once per frame
    void Update()
    {
        blindness = passiveStatus(blindness, 5);
        if (blindness <= 0)
            Destroy(gameObject);
    }

    float passiveStatus(float status, float seconds) //Hunger decreasing
    {
        if (status > 0)
            status -= Time.deltaTime / (seconds) * (100/60);
        else
            status = 0;

        return status;
    }
}

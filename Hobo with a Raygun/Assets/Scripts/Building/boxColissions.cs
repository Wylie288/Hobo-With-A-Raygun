/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxColissions : MonoBehaviour
{
    void OnCollisionEnter(Collision boxDetection)
    {
        if (boxDetection.gameObject.name == "blueSquare")
        {
            Color color = GetComponent<Renderer>().material.color;
            gameObject.color.a = 1.0f;
        }
    }
} */
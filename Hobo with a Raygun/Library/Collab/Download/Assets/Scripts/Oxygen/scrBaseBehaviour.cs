using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrBaseBehaviour : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
	    if (other.gameObject.tag == "Player")     
            GameObject.FindGameObjectWithTag("Player").GetComponent<scrOxygone>().setBase(1);
    }

    void OnTriggerExit2D(Collider2D other)
    {
      if (other.gameObject.tag == "Player")
        	GameObject.FindGameObjectWithTag("Player").GetComponent<scrOxygone>().setBase(0);
    }
}
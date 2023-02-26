using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisions : MonoBehaviour
{
    public GameObject greenSquare;
    public GameObject redSqre;
    public GameObject blueSquare;
    bool isHit = false;
    bool redSpawned = false;
    bool greenSpawned = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((isHit == true) && (redSpawned == false))
        {
            redSpawn();
            greenDel();
            redSpawned = true;
            greenSpawned = false;
            isHit = false;

        }
        //constantly check what is colliding
        //constantly check to make sure no collision with box
        if ((isHit == false) && (greenSpawned == false))
        {
            Debug.Log("HI");
            greenSpawn();
            redDel();
            greenSpawned = true;
            redSpawned = false;
        }
    }
    void redSpawn()
    {
        Instantiate(redSqre,new Vector3(1000, 0, 0),Quaternion.identity);
        redSpawned = true;
        greenSpawned = false;
    }
    void greenSpawn()
    {
        Instantiate(greenSquare,new Vector3(1000, 0, 0),Quaternion.identity);
        greenSpawned = true;
        redSpawned = false;
    }
    void redDel()
    {
        DestroyImmediate(redSqre, true);
    }
    void greenDel()
    {
        DestroyImmediate(greenSquare, true);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "blueSquare(Clone)")
        {
            isHit = true;
        //    Debug.Log("IM HIT");
        }

       // else if (col.gameObject.name == "testingBoundary")
       // {
       //     isHit = true;
       // }
       //do ray
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "blueSquare(Clone)")
        {
            isHit = false;
        }
    }
}
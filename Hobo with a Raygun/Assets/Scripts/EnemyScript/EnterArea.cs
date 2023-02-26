using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterArea : MonoBehaviour
{
    public GameObject player;
    public MoveEnemy[] mve;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mve = GetComponentsInChildren<MoveEnemy>();
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        //Debug.Log("Enter");
        if(coll.gameObject == player)
        {
            player.transform.parent = transform;
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject == player)
        {
            player.transform.parent = null;
        }
        foreach (MoveEnemy m in mve)
        {
            m.sc = 1;
            m.CancelInvoke("EnemyShoot");
        }
    }
}

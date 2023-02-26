using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public HealthScript[] h;
    private float sec;
    // Start is called before the first frame update
    void Start()
    {
        sec = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        h = GameObject.FindObjectsOfType<HealthScript>();
        sec += Time.deltaTime;
        if (sec >= 5.0f)
            Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        foreach(HealthScript e in h)
        {
            if(coll.gameObject == e.gameObject)
            {
                e.Damage(10.0f);
                Destroy(gameObject);
            }
        }
    }
}

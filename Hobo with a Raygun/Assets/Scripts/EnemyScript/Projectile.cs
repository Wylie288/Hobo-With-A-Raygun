using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public scrPlayerHealth health;
    private float sec;
    // Start is called before the first frame update
    void Start()
    {
        sec = 0.0f;
        health = GameObject.FindObjectOfType<scrPlayerHealth>();
    }
    // Update is called once per frame
    void Update()
    {
        sec += Time.deltaTime;
        if (sec >= 5.0f)
            Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject == GameObject.FindGameObjectWithTag("Player"))
        {
            health.TakeDamage(10.0f);
            Destroy(gameObject);
        }
    }
}

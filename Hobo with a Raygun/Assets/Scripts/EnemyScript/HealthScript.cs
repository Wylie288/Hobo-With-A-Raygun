using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    
    private float MAX_HEALTH = 50;
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        //FindHealth();
        health = MAX_HEALTH;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0.0f)
        {
            Destroy(gameObject);
        }
    }
    
    public void Damage(float d)
    {
        health = health - d;
    }
}

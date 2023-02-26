using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrPlayerLook : MonoBehaviour
{
    private Vector2 direction; //Facing direction
    private Vector3 mousePosition; //Mouse position

    void Start()
    {
        
    }

    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        direction.x = mousePosition.x - transform.position.x;
        direction.y = mousePosition.y - transform.position.y;
    }

    void FixedUpdate()
    {
        transform.up = direction;
    }
}

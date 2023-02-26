using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrPlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed; //Movement Speed
    private Vector2 moveVelocity; //Movement Vector
    private Vector2 moveInput; //Movement Input

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveVelocity = moveInput.normalized * speed;

        if (Input.GetKeyDown (KeyCode.L))
            rb.position = PlayerPrefsX.GetVector2("PlayerPos", new Vector2(0,0));
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity);
        
        PlayerPrefsX.SetVector2 ("PlayerPos", rb.position);
    }
}

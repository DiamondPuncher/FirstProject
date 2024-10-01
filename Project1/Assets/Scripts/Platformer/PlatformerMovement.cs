using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMovement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 1.0f;
    [SerializeField]
    float jumpSpeed = 2.0f;
    Rigidbody2D rb;
    bool grounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        //left and right movement based on horixontal axis input
        float moveX = Input.GetAxis("Horizontal");
        Vector2 velocity = rb.velocity;
        velocity.x = moveX * moveSpeed;
        rb.velocity = velocity;
        //jump when we hit spacebar
        if (Input.GetButtonDown("Jump") && grounded)
        {
            rb.AddForce(new Vector2(0, 100 * jumpSpeed));
            grounded = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 6)
        {
            grounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            grounded = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            grounded = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    bool isJumping;
    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         float move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2 (speed * move, rb.velocity.y);
        Jump();
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping){
            isJumping = true;

            rb.AddForce(new Vector2(rb.velocity.x, jumpForce));
 
        }
    }
    
}

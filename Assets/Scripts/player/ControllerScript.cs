using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    public float moveSpeed;
    public float jumpForce = 5f;
    public Transform feet;
    public LayerMask groundLayers;
    public float feetRadius; 

    float dir;

    void Start() {
        rb = this.GetComponent<Rigidbody2D>();
        anim = this.GetComponent<Animator>();
    }

    void Update() {
        dir = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && IsGrounded()) {
            Jump();
        }

        if (dir > 0) {
            anim.SetBool("WalkRight", true);
        } else if(dir < 0) {
            anim.SetBool("WalkLeft", true);
        } else {
            anim.SetBool("WalkRight", false);
            anim.SetBool("WalkLeft", false);
        }
    }

    void FixedUpdate() {
        Movement();
    }

    void Movement() {
        Vector2 movement = new Vector2(dir * moveSpeed, rb.velocity.y);
        rb.velocity = movement;
    }

    void Jump() {
        Vector2 movement = new Vector2(rb.velocity.x, jumpForce);
        rb.velocity = movement;
    }

    public bool IsGrounded() {
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, feetRadius, groundLayers);

        if (groundCheck != null) {
            return true;
        }

        return false;
    }

}

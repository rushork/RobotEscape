using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogController : MonoBehaviour
{

    private Rigidbody2D rb;
    public Transform spawnpoint;
    public float speed;
    private float startSpeed;
    public PlayerScript player;
    

    // Start is called before the first frame update
    void Start() {
        startSpeed = speed;
        rb = this.GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerScript>();
    }

    // Update is called once per frame
    void Update() {
        Movement();
    }

    void Movement() {
        speed += 0.001f;
        Vector2 movement = new Vector2(speed, rb.velocity.y);
        rb.velocity = movement;
    }

    public void Respawn() {
        GetComponent<Rigidbody2D>().position = spawnpoint.position;
    }

    void OnCollisionEnter2D(Collision2D other) {
        speed = startSpeed;
        this.Respawn();
        player.Respawn();
    }



}

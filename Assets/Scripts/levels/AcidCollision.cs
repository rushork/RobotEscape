using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidCollision : MonoBehaviour
{

    PlayerScript player;
    FogController fog;

    void Start() {
        player = FindObjectOfType<PlayerScript>();
        fog = FindObjectOfType<FogController>();
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Player"))
        {
            fog.Respawn();
            fog.speed = 0.5f;
            player.Respawn();
        }
    }

}

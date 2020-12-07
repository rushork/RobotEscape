using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public Transform spawnpoint;
    HealthScript playerHealth;

    void Start() {
        playerHealth = GetComponent<HealthScript>();
        playerHealth.currentHealth = 3;
    }

    public void Respawn() {
        if (playerHealth.currentHealth > 0) {
            playerHealth.currentHealth -= 1;
        }
        GetComponent<Rigidbody2D>().position = spawnpoint.position;
    }


}

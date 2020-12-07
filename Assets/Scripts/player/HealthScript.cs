using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour
{
    
    private int numOfHearts = 3;
    public int currentHealth;
    public Image[] hearts;
    public Sprite heartSprite;
    public Sprite emptySprite;
    
    void Update() {
        HeartUpdate();
    }

    void HeartUpdate() {
        for (int i = 0; i < numOfHearts; i++) {
            if (i < currentHealth) {
                hearts[i].sprite = heartSprite;
            } else {
                hearts[i].sprite = emptySprite;
            }
            if (i < numOfHearts) {
                hearts[i].enabled = true;
            } else {
                hearts[i].enabled = false;
            }
            if (currentHealth == 0) {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}

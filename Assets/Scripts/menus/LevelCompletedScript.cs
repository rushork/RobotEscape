using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCompletedScript : MonoBehaviour {
    
    public int currentLevel = 1;
    public int numOfLevels = 2;
    public GameObject[] levels;
    private ArrayList levelCompleted = new ArrayList();

    void Update() {
        LevelUpdate();
    }

    void updateLevel() {
        currentLevel += 1;
    }

    void LevelUpdate() {
        for (int i = 0; i < numOfLevels; i++) {
            if (i > currentLevel-1) {
                levels[i].SetActive(false);
            } else {
                levels[i].SetActive(true);
            }
        }
    }

    void ResetCurrentLevel() {
        currentLevel = 1;
    }

}

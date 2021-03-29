using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCompletedScript : MonoBehaviour {
    public GameObject[] levels;
    private int numOfLevels = 3;
    private static LevelSelectorScript[] level;
    public Text testText;
    
    void Start() {
        level = FindObjectsOfType<LevelSelectorScript>();
    }

    void FixedUpdate() {
        testText.text = "Current Level: " + StaticLevelScript.currentLevel.ToString();
        LevelUpdate();
    }

    void LevelUpdate() {
        /*
        for(int i = 0; i < numOfLevels; i++) {
            if (i > StaticLevelScript.currentLevel-1) {
                levels[i].SetActive(false);
            } else {
                levels[i].SetActive(true);
            }
        }
        */
    }

    void ResetCurrentLevel() {
        StaticLevelScript.currentLevel = 1;
    }


}

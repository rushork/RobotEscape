using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectorScript : MonoBehaviour {

    
    public int levelNumber;
    public string levelName;
    private bool completed;

    public void SendToLevel() {
        StaticLevelScript.indexLast = levelNumber;
        SceneManager.LoadScene(levelName);
    }

    public void ResetCurrentLevel() {
        StaticLevelScript.currentLevel = 1;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectorScript : MonoBehaviour {

    public string levelName;

    public void SendToLevel() {
        SceneManager.LoadScene(levelName);
    }
}

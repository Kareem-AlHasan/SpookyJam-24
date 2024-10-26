using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    [Header("Level To Load")]
    public string level;

    public void LoadNextLevel() {
        SceneManager.LoadScene(level);
    }
}
﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
    public void LoadNextScene() {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        int nextScene = (currentScene + 1) % 3;
        SceneManager.LoadScene(nextScene);
    }
}

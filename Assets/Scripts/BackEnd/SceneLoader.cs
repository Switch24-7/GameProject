﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneName;

    public void loadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void load()
    {
        SceneManager.LoadScene(sceneName);
    }
}

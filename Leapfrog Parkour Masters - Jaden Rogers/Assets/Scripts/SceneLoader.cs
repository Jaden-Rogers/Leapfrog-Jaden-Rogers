using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    private Scene currentScene;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //reload the current scene
    public void ReloadScene()
    {
        SceneManager.LoadScene(currentScene.name);
    }



}

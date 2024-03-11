using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float timeRemaining = 60;
    [SerializeField] private Text timerText;
    [SerializeField] private SceneLoader sceneLoader;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining <= 0)
        {
            sceneLoader.ReloadScene();
        }
        timerText.text = "Time Remaining: " + timeRemaining;
        
    }
}

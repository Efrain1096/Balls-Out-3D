using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTime : MonoBehaviour
{
    public GameObject pauseObject;
    public PauseGame pauseScript;
    public bool timeStopped = false;

    public GameObject displayText;

    public int minutes;
    public int seconds;


    // Start is called before the first frame update
    void Start()
    {
        countUpTimer();
        pauseScript = pauseObject.GetComponent<PauseGame>();

    }

    void countUpTimer()
    {
        if (!pauseScript.isPaused && !timeStopped) // If the game is not paused, keep counting time.
        {
            seconds++;
            if (seconds == 60)
            {
                seconds = 0;
                minutes++;
            }
            Invoke("countUpTimer", 1.0f);
            Debug.Log(seconds);
            Debug.Log(minutes);
        }
    }

    // Update is called once per frame
    void Update()
    {  
      displayText.GetComponent<Text>().text = minutes + ":" + seconds;
    }
}

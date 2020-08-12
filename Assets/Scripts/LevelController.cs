using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public GameObject timeObject;
    public DisplayTime timeScript;

    public GameObject Player;
    private int collisionCount = 0;
    private int levelIndex;
    public bool levelFinished = false;
    private void Start()
    {
        timeScript = timeObject.GetComponent<DisplayTime>();
        levelIndex = GlobalControl.Instance.levelIndex;
    }


    void Update()
    {
        if(levelIndex > 3) // Finished the last level (there are only three total). 
        {
            StartCoroutine(WaitToLoadScoreScreen()); // Wait a little bit for the transitioning of scenes
        }

        if(levelIndex == 1 && !levelFinished)
        {
            UpdateLevelOneTime();
        }
        if(levelIndex == 2 && !levelFinished)
        {
            UpdateLevelTwoTime();
        }

        if (levelIndex == 3 && !levelFinished)
        {
            UpdateLevelThreeTime();
        }

    }

    private void UpdateLevelOneTime()
    {
        GlobalControl.Instance.levelOneSeconds = timeScript.seconds;
        GlobalControl.Instance.levelOneMinutes = timeScript.minutes;
    }

    private void UpdateLevelTwoTime()
    {
        GlobalControl.Instance.levelTwoSeconds = timeScript.seconds;
        GlobalControl.Instance.levelTwoMinutes = timeScript.minutes;
    }
    private void UpdateLevelThreeTime()
    {
        GlobalControl.Instance.levelThreeSeconds = timeScript.seconds;
        GlobalControl.Instance.levelThreeMinutes = timeScript.minutes;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player && collisionCount == 0)
        {
            collisionCount = 1;
            levelFinished = true;
            levelIndex++;
            GlobalControl.Instance.levelIndex = levelIndex;
            string nextLevel = "Level" + levelIndex;
            StartCoroutine(LoadNextLevel(nextLevel));

        }
    }



    IEnumerator WaitToLoadScoreScreen()
    {
        yield return new WaitForSeconds(3.8f);
        SceneManager.LoadScene("ScoreScreen");
    }

    IEnumerator LoadNextLevel(string nextLevel)
    {
        yield return new WaitForSeconds(3.7f);
        SceneManager.LoadScene(nextLevel);

    }
}

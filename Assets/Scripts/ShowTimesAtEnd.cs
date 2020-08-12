using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTimesAtEnd : MonoBehaviour
{
    public Text levelOneTime;
    public Text levelTwoTime;
    public Text levelThreeTime;

    void Update()
    {
        levelOneTime.text = "Level 1 Time: " + GlobalControl.Instance.levelOneMinutes + ":" + GlobalControl.Instance.levelOneSeconds;
        levelTwoTime.text = "Level 2 Time: " + GlobalControl.Instance.levelTwoMinutes + ":" + GlobalControl.Instance.levelTwoSeconds;
        levelThreeTime.text = "Level 3 Time: " + GlobalControl.Instance.levelThreeMinutes + ":" + GlobalControl.Instance.levelThreeSeconds;
    }
}

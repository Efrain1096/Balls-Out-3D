using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    public static GlobalControl Instance { get; private set; }

    public int levelOneMinutes = 0;
    public int levelOneSeconds = 0;

    public int levelTwoMinutes = 0;
    public int levelTwoSeconds = 0;

    public int levelThreeMinutes = 0;
    public int levelThreeSeconds = 0;

    public int levelIndex = 1;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
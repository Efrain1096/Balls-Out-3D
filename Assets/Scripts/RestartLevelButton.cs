using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevelButton : MonoBehaviour
{
    [SerializeField]
    KeyCode restartkey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(restartkey))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Restart the current level/scene
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnCollision : MonoBehaviour
{
    [SerializeField]
    string restartTag;
    int collisions = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == restartTag && collisions == 0)
        {
            StartCoroutine(RestartLevel());
            collisions = 1;
        }
    }


    IEnumerator RestartLevel()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Restart the current level/scene

    }

}

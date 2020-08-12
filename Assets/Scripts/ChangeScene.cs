using UnityEngine;
using UnityEngine.SceneManagement;



public class ChangeScene : MonoBehaviour
{
  
    public void PlayScene()
    {
        GlobalControl.Instance.levelIndex = 1;
        SceneManager.LoadScene("Level1");
    }

    public void HowToScene()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void MenuScene()
    {
        SceneManager.LoadScene("Menu");
        GlobalControl.Instance.levelOneSeconds = 0;
        GlobalControl.Instance.levelOneMinutes = 0;
        GlobalControl.Instance.levelTwoSeconds = 0;
        GlobalControl.Instance.levelTwoMinutes = 0;
        GlobalControl.Instance.levelThreeSeconds = 0;
        GlobalControl.Instance.levelThreeMinutes = 0;
        GlobalControl.Instance.levelIndex = 1;

    }
    public void TutorialScene()
    {
        SceneManager.LoadScene("HowToPlay");
    }

    public void ScoreScene()
    {
        SceneManager.LoadScene("ScoreScreen");
    }

    public void SynopsisScreen()
    {
        SceneManager.LoadScene("Synopsis");
    }

    public void CreditsScene()
    {
        SceneManager.LoadScene("Credits");
    }
    public void QuitGame()
    {
        //Only works when built and run as an application
        Application.Quit();
    }
}
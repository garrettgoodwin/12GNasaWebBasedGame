using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{




    public void StartStoryMode()
    {
        SceneManager.LoadScene("StoryMode");  
    }

    public void StartTutorial()
    {
        SceneManager.LoadScene("Tutorial");  
    }

    public void StartEndlessMode()
    {
        SceneManager.LoadScene("EndlessMode");  
    }

    public void OpenOptions()
    {
        SceneManager.LoadScene("Options");  
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ToGameScene()
    {
        SceneManager.LoadScene("Main");
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionManager : MonoBehaviour
{
    public SceneTransition currentTransition;

    public void ChangeScene(string sceneName)
    {
        StartCoroutine(TransitionToScene(sceneName));
    }

    private IEnumerator TransitionToScene(string sceneName)
    {
        currentTransition.InitializeTransition();
        yield return new WaitForSeconds(currentTransition.duration);
        currentTransition.PerformTransition();
        
        SceneManager.LoadScene(sceneName);

        currentTransition.EndTransition();
    }
}

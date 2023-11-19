using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameTime : MonoBehaviour
{
    //Very Sublt Original Starting time
    [SerializeField] private float sleepTimeDuration = 0.02f;

    void PauseGame()
    {
        if(Time.timeScale != 0.15f)
        {
            Time.timeScale = 0.15f;
        }
    }

    void ResumeGame()
    {
        if(Time.timeScale != 1)
        {
            Time.timeScale = 1;
        }
    }

    IEnumerator SubtleGamePause()
    {
        Time.timeScale = 0;
        yield return new WaitForSeconds(sleepTimeDuration);
        Time.timeScale = 1;
    }
}
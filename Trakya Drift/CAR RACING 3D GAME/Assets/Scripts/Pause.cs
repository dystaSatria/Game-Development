using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject playerUI;

    private bool gameIsPaused = false;
    public AudioSource musicAudioSource;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (gameIsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
       
        Time.timeScale = 0f;

        
        gameIsPaused = true;
        //musicAudioSource.Pause();
    }

    public void ResumeGame()
    {
        pauseMenuUI.SetActive(false);

        if (playerUI != null)
        {
            playerUI.SetActive(true);
        }

        Time.timeScale = 1f;

        gameIsPaused = false;
    }

}

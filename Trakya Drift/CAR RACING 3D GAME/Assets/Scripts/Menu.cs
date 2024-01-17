using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{



    
    [Header("All Menus")]
    public GameObject pauseMenuUI;
    public GameObject playerUI;
    public static bool GameIsStopped = false ;

    public AudioSource musicAudioSource;

    

    public void Resume()
    {
        
        pauseMenuUI.SetActive(false);
        playerUI.SetActive(true);
        Time.timeScale = 1f;
        //musicAudioSource.UnPause();
        //GameIsStopped = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene("scene_day");
        Time.timeScale = 1f;
    }

    public void Pause()
    {

   
            pauseMenuUI.SetActive(true);
            playerUI.SetActive(false);
            Time.timeScale = 0f;
            GameIsStopped = true;
            //musicAudioSource.Pause();
    }

   
    public void QuitGame()
    {
        

        Debug.Log("Quitting Game");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // If not running in the editor, try to quit the application
        // Note: Application.Quit may not work on all platforms
        Application.Quit();
#endif
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject x;

    //Setting the canva off
    void Start(){
        x.SetActive(false);
    }
    
    // Condition to get the canva on
    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
                Resume();
            else
            {
                Debug.Log("log");
                Pause();
            }
        }
    }

    //Scripting the resume
    public void Resume(){
        x.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Scripting the pausing
    public void Pause(){
        x.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    //Scripting the options button
    public void Options(){
        PlayerPrefs.SetInt("PreviousLevel", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Options");
    }

    //Scriptiing the Restart button
    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Scripting Menu Button
    public void MainMenu(){
        SceneManager.LoadScene("MainMenu");
    }

}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    //Setting up prvious Scene
    void Start()
    {
        PlayerPrefs.SetInt("PreviousLevel", SceneManager.GetActiveScene().buildIndex);
    }

    // Function for buttons to choose the level
    public void LevelSelect(int level)
    {
        SceneManager.LoadScene(level);
    }

    // Scripting Option button to get me to option scene
    public void Options()
    {
        SceneManager.LoadScene(4);
    }

    // scripting the Exit button
    public void Exit()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}

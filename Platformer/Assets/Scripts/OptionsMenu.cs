using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    // Scripting the back button to load the last scene
    public void Back()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("PreviousLevel"));
    }
}

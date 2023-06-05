using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Toggle yAxis;

    public void Start()
    {
        bool toggled = PlayerPrefs.GetInt("IsInverted") == 1 ? true : false;
        yAxis.isOn = toggled;
    }

    // Scripting the back button to load the last scene
    public void Back()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("PreviousLevel"));
        if (Time.timeScale == 0)
            Time.timeScale = 1;
    }

    public void Apply()
    {
        if (!yAxis.isOn)
            PlayerPrefs.SetInt("IsInverted", 0);
        else
            PlayerPrefs.SetInt("IsInverted", 1);
        Back();
    }
}

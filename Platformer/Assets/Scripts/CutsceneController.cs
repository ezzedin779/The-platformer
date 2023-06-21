using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneController : MonoBehaviour
{
    public Animator anm;
    public GameObject mainCamera;
    public GameObject cutsceneCamera;
    public GameObject player;
    public GameObject timerCanvas;
    
    void Start()
    {
        player.GetComponent<PlayerController>().enabled = false;
        player.GetComponent<Timer>().enabled = false;
        mainCamera.SetActive(false);
        timerCanvas.SetActive(false);
    }

    public void CutsceneEnd()
    {
        player.GetComponent<PlayerController>().enabled = true;
        mainCamera.SetActive(true);
        timerCanvas.SetActive(true);
        cutsceneCamera.SetActive(false);
    }
}

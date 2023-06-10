using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinFlag : MonoBehaviour
{
    public GameObject Player;
    public Text TimerText;
    public GameObject winCanvas;

    void OnTriggerEnter(Collider other)
    {
        TimerText.enabled = false;
        winCanvas.SetActive(true);
        Time.timeScale = 0;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        //Player.GetComponent<Timer>().enabled = false;
        //TimerText.color = new Color(0, 255, 0);
       // TimerText.fontSize = 90;
    }
}

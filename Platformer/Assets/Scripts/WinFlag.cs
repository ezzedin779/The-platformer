using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinFlag : MonoBehaviour
{
    public GameObject Player;
    public Text TimerText;

    void OnTriggerEnter(Collider other)
    {
        Player.GetComponent<Timer>().enabled = false;
        TimerText.color = new Color(0, 255, 0);
        TimerText.fontSize = 90;
    }
}

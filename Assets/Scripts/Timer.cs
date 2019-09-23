using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TimerText;
    private float TimeCounter = 0f;
    void Update()
    {
        TimeCounter += Time.deltaTime;
        TimerText.text = TimeCounter.ToString("n1");
    }
}

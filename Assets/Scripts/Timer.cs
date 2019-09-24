using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI TimerText;
    private float TimeCounter = 0f;

    private int n1, n2;
    void Update()
    {
        TimeCounter += Time.deltaTime;
        TimerText.text = string.Format("{0}" , TimeCounter.ToString("f1"));
    }
}

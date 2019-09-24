using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public int SceneIndex;
    public TimeController TC;
    public Timer timer;

    private void Awake()
    {
        TC = FindObjectOfType<TimeController>();
        timer = FindObjectOfType<Timer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            TC.level1 = float.Parse(timer.TimerText.text);
        } else
        {
            TC.level2 = float.Parse(timer.TimerText.text);
        }
        SceneManager.LoadScene(SceneIndex);
    }
}

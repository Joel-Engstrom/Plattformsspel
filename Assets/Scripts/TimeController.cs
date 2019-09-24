using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeController : MonoBehaviour
{
    
    public float level1 = 0f;
    public float level2 = 0f;

    private float totalTime;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    private void Update()
    {
        totalTime = level1 + level2;
        if (SceneManager.GetActiveScene().buildIndex == 3)
        {
            GameObject.FindGameObjectWithTag("Level1tid").GetComponent<TextMeshProUGUI>().text = level1.ToString() + " S";
            GameObject.FindGameObjectWithTag("Level2tid").GetComponent<TextMeshProUGUI>().text = level2.ToString() + " S";
            GameObject.FindGameObjectWithTag("TotaltidTid").GetComponent<TextMeshProUGUI>().text = totalTime.ToString() + " S";
        }
    }
}

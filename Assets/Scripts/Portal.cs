﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public int SceneIndex;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneIndex);
    }
}

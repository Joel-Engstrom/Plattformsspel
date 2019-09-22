using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pil : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Time.timeScale = 0f;
        } else if (col.tag != "Pil")
        {
            Destroy(gameObject);
        }
    }
}

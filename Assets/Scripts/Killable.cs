using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killable : MonoBehaviour
{
    public GameObject DeathEffect;
    public GameObject DeathScreen;
    private void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
        Instantiate(DeathEffect, col.transform.position, Quaternion.identity);
        Destroy(gameObject, 1f);
        DeathScreen.SetActive(true);
    }
}

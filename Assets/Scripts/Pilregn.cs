using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pilregn : MonoBehaviour
{
    [Header("Prefaben som ska spawnas")]
    public GameObject Pil;

    [Header("Tiden mellan varje pil")]
    public float RespawnTime = 2;

    [Header("Minimala stunden mellan varje pil")]
    [Range(0.01f, 0.2f)]
    public float MaxSpawnRate;

    [Header("Hur snabbt antalet pilar ökar med tiden")]
    [Range(0.0f, 0.02f)]
    public float RespawnRateIncrease = 0.01f;

    void Start()
    {
        StartCoroutine(SpawnArrows());
    }

    IEnumerator SpawnArrows()
    {
        Instantiate(Pil, transform.position, Quaternion.Euler(0,0,-90));
        yield return new WaitForSeconds(RespawnTime);
        if (RespawnTime >= MaxSpawnRate)
        {
            RespawnTime -= RespawnRateIncrease;
        }
        StartCoroutine(SpawnArrows());
    }
}

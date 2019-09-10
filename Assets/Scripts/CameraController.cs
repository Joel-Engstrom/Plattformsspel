using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset;

    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
}

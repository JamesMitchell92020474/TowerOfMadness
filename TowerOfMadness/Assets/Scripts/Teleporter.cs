using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject player;
    public AudioClip clip;

    void OnTriggerEnter(Collider collider)
    {
        player.transform.position = teleportTarget.transform.position;
    }
}

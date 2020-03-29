using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip[] CollisionSound;

    void OnTriggerEnter()
    {
        AudioSource.PlayClipAtPoint(CollisionSound[Random.Range(0, CollisionSound.Length)], transform.position);
    }
}

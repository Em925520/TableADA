using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Say_Hey : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.5f;
    void OnCollisionEnter(Collision collision)
    {
        audioSource.PlayOneShot(clip, volume);
    }
}

/*
 * public class PlayOnCollision : MonoBehaviour
{
    public AudioSource audioSource;
    void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();
    }
}

*/
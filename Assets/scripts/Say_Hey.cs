using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Say_Hey : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        m_MyAudioSource = GetComponent<AudioSource>();
        m_MyAudioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
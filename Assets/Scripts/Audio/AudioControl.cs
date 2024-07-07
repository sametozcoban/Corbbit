using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public AudioSource music;
    // Start is called before the first frame update
    void Start()
    {
        music.Play();
    }
    
    private void OnEnable()
    {
        Health.isLive += StopAudio;
    }

    private void OnDisable()
    {
        Health.isLive -= StopAudio;
    }

    private void StopAudio()
    {
        music.Stop();
    }
}

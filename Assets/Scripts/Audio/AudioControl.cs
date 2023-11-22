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

    private void Update()
    {
       // if (GameObject.FindGameObjectWithTag("Player").GetComponent<Health>().kalp == 0)
       // {
       //     music.Stop();
       // }
    }
}

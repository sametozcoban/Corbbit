using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public int kalp;
    public int kalpSayisi;

    public Image[] kalpler;
    public Sprite fullKalp;
    public Sprite bosKalp;

    private void Awake()
    {
        kalp = 3;
        kalpSayisi = 3;
    }

    private void Update()
    {
        if (kalp > kalpSayisi)
        {
            kalp = kalpSayisi;
        }

        for ( int i = 0; i < kalpler.Length; i++)
        {
            if (i < kalp)
            {
                kalpler[i].sprite = fullKalp;
            }
            else
            {
                kalpler[i].sprite = bosKalp;
            }
            if (i < kalpSayisi)
            {
                kalpler[i].enabled = true;
            }
            else
            {
                kalpler[i].enabled = false;
            }
        }

        if (kalp == 0)
        {
            Destroy(gameObject);
        }
    }
}  // blablabla

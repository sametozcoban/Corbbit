using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public int kalp = 3;
    public int kalpSayisi = 3;
    public Image[] kalpler;
    public Sprite fullKalp;
    public Sprite bosKalp;

    public static event Action isLive;

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

        for (int i = 0; i < kalpler.Length; i++)
        {
            if (i < kalp)
            {
                kalpler[i].sprite = fullKalp;
            }
            else
            {
                kalpler[i].sprite = bosKalp;
            }

            kalpler[i].enabled = (i < kalpSayisi);
        }

        IsDead();
    }

    public void IsDead()
    {
        if (kalp == 0)
        {
            isLive?.Invoke();
            Destroy(gameObject);
        }
    }
}  

using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void OnEnable()
    {
        Health.isLive += StopGame;
    }

    private void OnDisable()
    {
        Health.isLive -= StopGame;
    }

    private void StopGame()
    {
        Time.timeScale = 0f;
    }
}

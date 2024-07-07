using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour
{
    public GameObject sceneUI;
    private Health playerHealth;

    private void OnEnable()
    {
        Health.isLive += OnPlayerDead;
    }

    private void OnDisable()
    { 
        Health.isLive -= OnPlayerDead;
    }

    private void Start()
    {
        playerHealth = GetComponent<Health>();
        sceneUI.SetActive(false);
    }

    private void OnPlayerDead()
    {
        if (sceneUI.activeSelf)
        {
            sceneUI.SetActive(false);
        }
        else sceneUI.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainManu");
    }
}

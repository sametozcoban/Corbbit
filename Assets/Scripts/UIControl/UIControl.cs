using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIControl : MonoBehaviour
{
    public GameObject sceneUI;

    private void Start()
    {
        sceneUI.SetActive(false);
    }

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<Health>().kalp == 0)
        {
            Debug.Log("öldün");
            sceneUI.SetActive(true);
        }
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

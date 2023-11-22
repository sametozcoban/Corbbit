using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMaAaAnu : MonoBehaviour
{
    public TextMeshProUGUI buttonText;
    public GameObject buttons;
    public GameObject exitButton;
    public GameObject createdBy;

    private bool isPressed;
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void HaHa()
    {
        buttons.SetActive(false);
        buttonText.gameObject.SetActive(false);
        exitButton.SetActive(true);

    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void CreatedBy()
    {
        if (!isPressed)
        {
            buttons.SetActive(false);
            buttonText.gameObject.SetActive(false);
            exitButton.SetActive(false);
            createdBy.SetActive(true);
            isPressed = true;
        }
        else
        {
            buttons.SetActive(true);
            buttonText.gameObject.SetActive(true);
            createdBy.SetActive(false);
            isPressed = false;
        }
        
    }
}

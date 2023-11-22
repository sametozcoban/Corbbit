using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private TextMeshProUGUI buttonText;
    private Color normalColor;
    public Color hoverColor = Color.green;

    private void Start()
    {
        // Script ba�lad���nda butonun normal rengini al.
        buttonText = GetComponentInChildren<TextMeshProUGUI>();
        normalColor = buttonText.color;
    }

    // Mouse buton �zerine geldi�inde �al��acak fonksiyon.
    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonText.color = hoverColor; // Rengi de�i�tir.
    }

    // Mouse butondan ��k�ld���nda �al��acak fonksiyon.
    public void OnPointerExit(PointerEventData eventData)
    {
        buttonText.color = normalColor; // Orijinal rengine d�nd�r.
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanvasTextGlobalSpace : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textMeshPro;


    public void SetText(string text)
    {
        textMeshPro.text = text;
    }
}

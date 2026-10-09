using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI points;
    private int iPoints = 0;
    
    public void UpdateUI()
    {
        iPoints += 100;
        points.text = iPoints.ToString();
    }
}

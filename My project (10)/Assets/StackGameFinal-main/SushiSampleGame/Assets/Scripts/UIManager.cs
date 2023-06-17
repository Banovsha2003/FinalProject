using System;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
   
    public static UIManager Instance { get; set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void OnEnable()
    {
        Time.timeScale = 0;
    }

    public void OnClickStart()
    {
        Time.timeScale = 1;
    }

}
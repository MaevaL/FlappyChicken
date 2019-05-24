using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject GameOverUI;

    private void Start()
    {
        GameController.instance.GameOverEvent += OnGameOver;
        GameController.instance.RestartEvent += OnRestart;
    }

    private void OnRestart()
    {
        GameOverUI.SetActive(false);
    }

    private void OnGameOver()
    {
        GameOverUI.SetActive(true);
        
    }

    
}

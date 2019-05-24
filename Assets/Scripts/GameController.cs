using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static GameController instance = null;
    public bool isGameOver = false;
    public CameraController cameraController;
    public FlappyController flappyController;
    public Animator flappyAnimator;

    
    public delegate void GameOverHandler();
    public event GameOverHandler GameOverEvent;
    public event GameOverHandler RestartEvent;

    public float speedScrolling = 0.02f;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        } else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (isGameOver)
        {
            if (Input.GetMouseButtonDown(0)){
                if(RestartEvent != null)
                {
                    OnRestart();
                    RestartEvent();
                }
                 
            }
        }
    }
    public void OnGameOver()
    {
        isGameOver = true;
        if(GameOverEvent != null)
        {
            GameOverEvent();
        }
        flappyAnimator.SetBool("isGameOver", true);
    }

    public void OnRestart()
    {
        isGameOver = false;
        flappyAnimator.SetBool("isGameOver", false);
    }


}

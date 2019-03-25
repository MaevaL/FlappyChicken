using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public static GameController instance = null;
    public bool isGameOver = false;
    public CameraController cameraController;
    public FlappyController flappyController;
    public Animator flappyAnimator;

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

    public void OnGameOver()
    {
        isGameOver = true;
        flappyAnimator.SetBool("isGameOver", true);
    }


}

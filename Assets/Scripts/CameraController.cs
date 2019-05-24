using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private float speed = 0.02f;
    private Vector3 start;
    private void Awake()
    {
        start = transform.position;
    }

    private void Start()
    {
        GameController.instance.RestartEvent += OnRestart;
    }

    private void OnRestart()
    {
        transform.position = start;
    }

    // Update is called once per frame
    void Update () {
        if (GameController.instance.isGameOver)
            return;

        transform.position += new Vector3(1, 0, 0) * GameController.instance.speedScrolling;
    }
}

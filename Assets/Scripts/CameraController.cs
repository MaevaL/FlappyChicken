using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    private float speed = 0.02f;

	// Update is called once per frame
	void Update () {
        if (GameController.instance.isGameOver)
            return;

        transform.position += new Vector3(1, 0, 0) * GameController.instance.speedScrolling;
    }
}

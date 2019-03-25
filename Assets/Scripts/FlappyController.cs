using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyController : MonoBehaviour {

    private Rigidbody rb;
    [SerializeField]
    private float forceX;
    [SerializeField]
    private ForceMode mode;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (GameController.instance.isGameOver)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(new Vector3(0, forceX, 0), mode);
        }
	}


    void OnCollisionEnter(Collision col)
    {
        Debug.Log("GameOver");
        GameController.instance.OnGameOver();
    }
}

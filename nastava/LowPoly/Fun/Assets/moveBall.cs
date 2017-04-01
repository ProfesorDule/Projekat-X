using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBall : MonoBehaviour {

    private GameObject ball;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        ball = GameObject.Find("gameBall");
        rb = ball.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float turn = Input.GetAxis("Horizontal");
        rb.AddTorque(transform.up * 1000 * turn);
	}
}

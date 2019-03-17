using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private float vel = 5;
	public GameObject Ball;
	Rigidbody2D Rb;

	void Awake() {
		Rb = GetComponent <Rigidbody2D> ();
	}

	public void UpwardVelocity () {
		Rb.velocity += Vector2.up * vel * Time.deltaTime;
	}

	public void DownwardVelocity () {
		Rb.velocity += Vector2.down * vel * Time.deltaTime;
	}

}



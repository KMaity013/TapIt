﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneController : MonoBehaviour {



	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			Ball.GetComponent <Movement> ().UpwardVelocity();
		}
	}	
}

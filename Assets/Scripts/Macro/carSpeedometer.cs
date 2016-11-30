﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class carSpeedometer : MonoBehaviour {

	private Rigidbody carRB;
	private float carSpeed;
	public bool isDefect = false;
	public Text speedText;


	// Use this for initialization
	void Start () {
		carRB = GetComponent<Rigidbody> ();
	}


	// Update is called once per frame
	void FixedUpdate () {
		if (!isDefect) {
			carSpeed = carRB.velocity.magnitude;
			carSpeed = carSpeed * (5.0f / 18.0f);
			carSpeed = (int)carSpeed;	
			speedText.text = "Speed " + carSpeed + " kmph";
		}
		else if (isDefect) {
			carSpeed = (int)carSpeed;	
			speedText.text = "Speed " + carSpeed + " kmph DEFECTIVE";
		}

	}
}
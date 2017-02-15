using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausedGame : MonoBehaviour {
	public bool buttonPressed;

	// Use this for initialization
	void Start () {
		Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) || Input.GetMouseButtonDown (1) || Input.GetMouseButtonDown (2)) {
			buttonPressed = true;
		}	

		if (!buttonPressed) {
			Time.timeScale = 0;
		} 
		else {
			Time.timeScale = 1;
			Destroy(gameObject);
		}

	}
}

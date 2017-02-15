using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour {
	public Rigidbody bullet;
	public float speed = 1000;

	// Use this for initialization
	void Start () {	
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) || Input.GetMouseButtonDown (1) || Input.GetMouseButtonDown (2)) {
			Rigidbody instantiatedProjectile = Instantiate (bullet, GameObject.Find("SpawnProjetil").transform.position, transform.rotation) as Rigidbody;
			instantiatedProjectile.AddForce(instantiatedProjectile.transform.forward * speed);
		}
	}
}

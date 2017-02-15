using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAnts : MonoBehaviour {
	public GameObject ant1fab;
	public GameObject ant2fab;
	public GameObject ant3fab;
	public static int ant1count;
	public static int ant2count;
	public static int ant3count;

	// Use this for initialization
	void Start () {	
		ant1count = 0;
		ant2count = 0;
		ant3count = 0;
	}

	// Update is called once per frame
	void Update () {
		if (ant1count == 0){
			Instantiate (ant1fab, GameObject.Find ("Ant1Spot").transform.position, GameObject.Find ("Ant1Spot").transform.rotation);
			ant1count++;
		}
		if (ant2count == 0){
			Instantiate (ant2fab, GameObject.Find ("Ant2Spot").transform.position, GameObject.Find ("Ant2Spot").transform.rotation);
			ant2count++;
		}
		if (ant3count == 0){
			Instantiate (ant3fab, GameObject.Find ("Ant3Spot").transform.position, GameObject.Find ("Ant3Spot").transform.rotation);
			ant3count++;
		}
	}

	
}

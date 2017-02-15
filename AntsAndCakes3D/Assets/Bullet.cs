using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public float timer = 0f;
	public float damage = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += 1.0F * Time.deltaTime;
		
		if (timer >= 4) {
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter(Collider anthit){
		Destroy(gameObject);
		if (anthit.gameObject.tag == "Ant1Enemy") {
			anthit.GetComponentInParent<Ant1>().TakeDamage(damage);
		} else if (anthit.gameObject.tag == "Ant2Enemy") {
			anthit.GetComponentInParent<Ant2>().TakeDamage(damage);
			//anthit.GetComponent<Ant2>().TakeDamage(damage);
		} else if (anthit.gameObject.tag == "Ant3Enemy") {
			anthit.GetComponentInParent<Ant3>().TakeDamage(damage);
			//anthit.GetComponent<Ant3>().TakeDamage(damage);
		}
	}
}
				
				
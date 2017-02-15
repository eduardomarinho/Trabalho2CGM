using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant1: MonoBehaviour {

	GameObject pathGO;
	GameObject cakeNode;
	GameObject anthillNode;

	Transform targetPathNode;
	int pathNodeIndex = 0;
	//atributos da formiga
	float speed = 5f;
	public float health = 10f;
	bool cake;
	public int antscore = 100;



	// Use this for initialization
	void Start () {
		pathGO = GameObject.Find ("Path1");
		cakeNode = GameObject.Find ("Path1/Path1spherecake");
		anthillNode = GameObject.Find ("Path1/Path1sphereanthill");
		cake = false;

	}

	void GetProximoNo(){
		targetPathNode = pathGO.transform.GetChild (pathNodeIndex);
		if (pathNodeIndex < 17) {
			pathNodeIndex++;
		}
	}
	// Update is called once per frame
	void Update () {
		Vector3 distcake = this.transform.localPosition - cakeNode.transform.position;
		if (distcake.magnitude <= 0.3f && !cake) {
			cake = true;
			GotCake();
			GameObject.FindObjectOfType<Score>().LoseCake();
		}

		Vector3 distanthill = this.transform.localPosition - anthillNode.transform.position;
		if (distanthill.magnitude <= 0.3f) {
			ReachedGoal();
		}

		if(targetPathNode == null){
			GetProximoNo();
			if (targetPathNode == null) {
				//Fim do caminho
				ReachedGoal();
			}
		}

		Vector3 dir = targetPathNode.position - this.transform.localPosition;
		float distThisFrame = speed * Time.deltaTime;

		if (dir.magnitude <= distThisFrame) {
			//chegamos no proximo no do caminho
			targetPathNode = null;
		}
		else {
			//move para o proximo no do caminho
			transform.Translate(dir.normalized * distThisFrame, Space.World);
			Quaternion targetRotation = Quaternion.LookRotation(dir);
			this.transform.rotation = Quaternion.Lerp (this.transform.rotation, targetRotation, Time.deltaTime*5);
		}

	}
	void ReachedGoal(){
		Destroy(gameObject);
		CreateAnts.ant1count = 0;
	}

	public void TakeDamage(float damage) {
		health -= damage;
		if (health <= 0) {
			Death();
		}
	}
	void GotCake(){
		GameObject.Find("Ant1(Clone)/fire-ant").GetComponent<Renderer>().material = GameObject.Find("Cake/Cylinder").GetComponent<Renderer>().material;
	}

	void Death(){
		Destroy(gameObject);
		GameObject.FindObjectOfType<Score>().score += antscore;
		CreateAnts.ant1count = 0;
	}
}

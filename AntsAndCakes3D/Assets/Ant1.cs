using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant1: MonoBehaviour {

	GameObject pathGO;

	Transform targetPathNode;
	int pathNodeIndex = 0;
	//atributos da formiga
	float speed = 5f;
	public float health = 50;

	// Use this for initialization
	void Start () {
		pathGO = GameObject.Find ("Path1");
	}

	void GetProximoNo(){
		targetPathNode = pathGO.transform.GetChild (pathNodeIndex);
		pathNodeIndex++;
	}
	// Update is called once per frame
	void Update () {
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
	}
}

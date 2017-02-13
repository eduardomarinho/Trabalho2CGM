#pragma strict
//Projetil que sai do inseticida
var inseticidaProjetilPrefab:Transform;


function Update () {
	//verifica se estamos atirando
	if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2)){
		var projetil = Instantiate(inseticidaProjetilPrefab, 
									GameObject.Find("SpawnProjetil").transform.position, 
									Quaternion.identity);
		projetil.GetComponent.<Rigidbody>().AddForce(transform.forward * 5000);
	}

}
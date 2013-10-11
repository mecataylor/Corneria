#pragma strict

function OnCollisionEnter(col : Collision){
	Destroy (gameObject, 1.5f);
	Destroy (col.gameObject);
}
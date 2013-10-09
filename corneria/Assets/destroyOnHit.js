#pragma strict

function Start () {

}

function Update () {

}

function OnCollisionEnter(col : Collision){
	Debug.Log(gameObject.name);
	Destroy (gameObject, 1.5f);
	Destroy (col.gameObject);
}
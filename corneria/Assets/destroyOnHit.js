#pragma strict

public var health = 3;
	
function Start () {
}

function Update () {
}

function OnCollisionEnter(col : Collision){
	health--;
	if (health <= 0)
	{
		Debug.Log(gameObject.name);
		Destroy (gameObject);
		Destroy (col.gameObject);
	}
}
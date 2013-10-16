#pragma strict

private var attacking : boolean = false;
private var player : GameObject = null;

function OnCollisionEnter(col : Collision){
	Destroy (gameObject, 1.5f);
	Destroy (col.gameObject);
	attacking = false;
}

function attack(toAttack : GameObject){
	attacking = true;
	player = toAttack;
}

function Update(){
	if (attacking && player != null){
		transform.LookAt(player.transform);
		//Lerp to a position just infront of the player
		var newposition = player.transform.position;
		newposition.z = player.transform.position.z + 100;
		transform.position = Vector3.Lerp(transform.position, newposition, Time.deltaTime);
	}
}
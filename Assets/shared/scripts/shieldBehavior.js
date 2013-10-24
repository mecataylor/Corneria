#pragma strict

public var duration : float = 0.5f;

function OnCollisionEnter(col : Collision){
	if(col.gameObject.layer == 12){
		Destroy(col.gameObject);
		//Add an explosion at the site of the collision
	}
}

function OnEnable(){
	Disable();
}

function Disable () {
	yield WaitForSeconds(duration);
	gameObject.SetActive(false);
}
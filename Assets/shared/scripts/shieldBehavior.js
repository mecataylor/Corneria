#pragma strict

public var duration : float = 0.5f;

function OnCollisionEnter(col : Collision){
	Destroy(col.gameObject);
}

function OnEnable(){
	Disable();
}

function Disable () {
	yield WaitForSeconds(duration);
	gameObject.SetActive(false);
}
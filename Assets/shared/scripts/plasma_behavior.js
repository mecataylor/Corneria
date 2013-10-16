#pragma strict

private var target : GameObject = null;
private var turnSpeed : float = 1000;

function Start(){
	Destroy (gameObject, 1.5f);
}

function Update () {
	transform.Rotate(Vector3.up + Vector3.right, turnSpeed * Time.deltaTime);
	if(target){
		transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime);
	}
}

function fire(toTarget : GameObject){
	target = toTarget;
}
#pragma strict

public var velocity : float;
public var player : Rigidbody;

function Update(){
	Instantiate(player, gameObject.position);
}
﻿#pragma strict

public var projectile : Rigidbody;
public var shootFrequency : float;
//The middle component of the enemy
public var middle : Transform;
//The tallest component of the enemy
public var height : Transform;

private var attacking : boolean = false;
private var player : GameObject = null;

function OnCollisionEnter(col : Collision){
	if(col.gameObject.name == "Laser(Clone)"){
		Destroy (gameObject, 1.5f);
		Destroy (col.gameObject);
		attacking = false;
	}
}

function attack(toAttack : GameObject){
	attacking = true;
	player = toAttack;
	fire();
}

function Update(){
	if (attacking && player){
		transform.LookAt(player.transform);
		//Lerp to a position just infront of the player
		var newposition : Vector3 = player.transform.position;
		newposition.z = player.transform.position.z + 100;
		newposition.y = player.transform.position.y - (height.renderer.bounds.size.y / 2);
		transform.position = Vector3.Lerp(transform.position, newposition, Time.deltaTime);
	}
}

function fire(){
	while(attacking){
		var projectileInstance : Rigidbody = Instantiate(projectile, middle.position, transform.rotation);
		if(player){
			projectileInstance.SendMessage("fire", player);
		}
		yield WaitForSeconds(shootFrequency);
	}
}
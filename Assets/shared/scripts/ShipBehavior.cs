using UnityEngine;
using System.Collections;

public class ShipBehavior : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
	}
	
	//when hit by enemy fire
	void OnCollisionEnter(Collision col){
		if(col.gameObject.layer == 12){
			Destroy(col.gameObject);
			gameObject.SendMessage("damage", 1);
		}
		
	}
	
	//message from Health class
	void healed(){
		
	}
	
	//message from Health class
	void dead(){
		Debug.Log("I'm dead!");
		
	}
	
	//message from Health class
	void damaged(){
		Debug.Log ("I'm hit");	
	}
}

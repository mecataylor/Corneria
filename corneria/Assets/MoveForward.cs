using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour
{
	public float speed = 10.0f;

	// Update is called once per frame
	void Update ()
	{
		transform.position += transform.forward*speed*Time.deltaTime;
		
		if(Input.GetButton("Fire3"))
		{
			speed = 40f;
		}
		if(Input.GetButtonUp("Fire3"))
		{
			speed = 10f;
		}
	}
}

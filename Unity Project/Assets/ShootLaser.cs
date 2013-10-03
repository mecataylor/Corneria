using UnityEngine;
using System.Collections;

public class ShootLaser : MonoBehaviour
{
	public Rigidbody bullet, missile;
	public float velocity = 100.0f;
	public int activeCamera = 1;  //1 for 1st person, 2 for rear, 3 for side
	public Camera a, b, c;

	// Update is called once per frame
	void Update ()
	{
		if(Input.GetButtonDown("Fire1"))
		{
			Vector3 shootVector = transform.position + new Vector3(1f, 0f, 1f);
			Rigidbody newLaser = Instantiate(bullet, shootVector, transform.rotation) as Rigidbody;
			newLaser.AddForce(transform.forward*velocity,ForceMode.VelocityChange);
		}
		
		if(Input.GetButtonDown("Fire2"))
		{
			Vector3 shootVector = a.transform.position + new Vector3(0f, -1.5f, 0f);
			Quaternion shootAngle = a.transform.rotation * Quaternion.Euler(0, -90, 0);
			Rigidbody newMissile = Instantiate(missile, shootVector, shootAngle) as Rigidbody;
			newMissile.AddForce(a.transform.forward*velocity/2,ForceMode.VelocityChange);
		}
		
		if(Input.GetButtonDown("Fire3"))
		{
			activeCamera++;
			if (activeCamera > 3) activeCamera = 1;
			if (activeCamera == 1)
			{
				a.enabled = true;
				b.enabled = false;
				c.enabled = false;
			}
			else if(activeCamera == 2)
			{
				a.enabled = false;
				b.enabled = true;
				c.enabled = false;
			}
			else
			{
				a.enabled = false;
				b.enabled = false;
				c.enabled = true;
			}
		}
	}
}

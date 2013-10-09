using UnityEngine;
using System.Collections;

public class ShipControl : MonoBehaviour {
	
	public int invert = 1;
	public float shipSpeed = 10f;
	public float rotateSpeed = 50f;
	public Camera mainCamera;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		
		Vector3 direction = new Vector3(horizontal,invert*vertical,0);
		Vector3 finalDirection = new Vector3(horizontal,invert*vertical,1.0f);
		
		transform.position += direction * shipSpeed*Time.deltaTime;
		float x = transform.position.x;
		float y = transform.position.y;
		float z = transform.position.z;
		
		if (x < -19f) x = -19f;
		if (x > 19f) x = 19f;
		if (y < -5f) y = -5f;
		if (y > 10f) y = 10f;
		
		direction = new Vector3(x, y, z);
		transform.position = direction;

		transform.rotation = Quaternion.RotateTowards(transform.rotation,Quaternion.LookRotation(finalDirection),Mathf.Deg2Rad*30.0f);
	}
}

using UnityEngine;
using System.Collections;

public class BulletKill : MonoBehaviour {

	float lifetime = 2.0f;
 
    void Awake()
    {
        GameObject.Destroy(this, lifetime * Time.deltaTime);
    }
}
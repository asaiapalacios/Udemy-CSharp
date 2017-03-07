using UnityEngine;
using System.Collections;

public class Ammo : MonoBehaviour
{
	// Lifetime for ammo
	public float AmmoLife = 2.0f;
	
	// Speed of ammo
	public float AmmoSpeed = 10.0f;
	
	// Use this for initialization
	IEnumerator Start()
	{
		// Wait for ammo life time
		yield return new WaitForSeconds(AmmoLife);
		
		// Destroy ammo
		Destroy(gameObject);
	}
	
	// Destroy on collision
	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag != "Player")
			Destroy(gameObject);
	}
	
	// Ammo travels in direction at speed
	void Update() // Event function called once per frame
	{
		// Control motion/movement of our ammunition
		transform.Translate(-Vector3.forward * AmmoSpeed * Time.deltaTime, Space.Self);
	}
}
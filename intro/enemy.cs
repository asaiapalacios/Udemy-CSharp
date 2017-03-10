using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	
	// Update is called once per frame
	void Update () 
	{
		// Rotate enemy cube object by 90 degrees per second around the y axis
		transform.Rotate (0,90 * Time.deltaTime,0); // Use transform class to rotate
	}
}
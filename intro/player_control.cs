using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
	// Prefab to instantiate
	public GameObject AmmoPrefab;

	public int Ammo = 10; 

	// Function to fire weapon for us
	string FireWeapon(int NumberofBullets)
	{
		// If run out of ammo (if statement is true), exit function block of code + return string
		if (Ammo <= 0) return "Fired Nothing"; // Note: return output matches the string return type
	
		// Otherwise (if statement is false) enter for loop and fire however many bullets we have specified for # of bullets
		for(int i=0; i<NumberofBullets; i++) 
		{ // When this condition is met...
			// Note: instantiate prefab
			Instantiate (AmmoPrefab); // allow player to fire weapon
		}
		Ammo = Ammo - NumberofBullets; // Calculate what new ammo count should be
		return "Fired Weapon";
	} 
		
	// Update is called once per frame
	void LateUpdate() // Note: event function being called automatically by the Unity engine
	{
		// If fire pressed
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			// Function call resolves to a string value (1 of 2 return strings) b/c it is the output of the function
			Debug.Log(FireWeapon(1)); // Insert in argument how many bullets (an int) we want to fire (1 bullet at a time in this case)
			// Print in the console log the return statement string the function call outputs 
		}
	}
}
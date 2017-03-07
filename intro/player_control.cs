using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
	// A list of weapons a player could find in the game
	public enum Weapons {Pistol=0, Rifle=1, ChainGun=2, PlasmaCan=3};

	// Prefab to instantiate
	public GameObject AmmoPrefab;

	public int Ammo = 10;

	// Specify our constant once and have it apply to our weapon variables
	public const int AMMO_COUNT = 15;

	// Starting value for weapon variables
	public int AmmoForPistol = AMMO_COUNT;
	public int AmmoForRifle = AMMO_COUNT;
	public int AmmoForChainGun = AMMO_COUNT; 

	// Variable indicates which weapon the player is currently carrying
	public Weapons WeaponWeAreCarrying; 

	// Update is called once per frame
	void LateUpdate()
	{
		// If fire pressed
		if (Input.GetKeyDown (KeyCode.Space)) {
			// Perform check (ammo count) to ensure we have enough ammo to fire
			if (Ammo > 0) { // When this condition is met...
				for(int i=0; i<3; i++) // for loop will fire our weapon 3 times
				{
					// Instantiate prefab
					Instantiate (AmmoPrefab); // allow player to fire weapon and
					Ammo = Ammo - 1; // ammo is reduced
				}
			} else // Otherwise...
			{
				Debug.Log ("Out of ammo"); // print this message to the console
			}
		}
	}
}
using UnityEngine;
using System.Collections;

public class MovingBoxes : MonoBehaviour 
{
	// Reference to array of boxes
	public GameObject[] Boxes;
	
	// Translate speed of boxes
	public Vector3 TranslateSpeed = Vector3.zero;
	
	// Max Y limit to reach before elevating next box
	public float MaxY = 20.0f;
	
	// Animate the cubes by raising each 
	IEnumerator MoveBoxes() // All coroutines must return the type IEnumerator 
	{
		// After waiting for 2 seconds... 
		yield return new WaitForSeconds(2.0f); 

		// we enter a foreach loop & cycle through all the 4 boxes in the Boxes array...
		foreach (GameObject Box in Boxes) 
		{
			// to test to see whether each box has reached its max destination height.					
			while (Box.transform.position.y < MaxY) 
			{
				// If it has not, then elevate box (by its speed) for the current frame 
				Box.transform.Translate (TranslateSpeed.x * Time.deltaTime, TranslateSpeed.y * Time.deltaTime, TranslateSpeed.z * Time.deltaTime); // Raise the box on the y axis by its current speed
				yield return null; // Return null statement waits until the next frame (rather than wait for a specified period of time like WaitForSeconds(2.0f)) 
								// Summary: We finished execution in this function for this frame, but for the next frame...
								// we come back to the return null statement to resume execution at the end of this line statement.
								// What this does: Returns back to the start of the while loop & begins to raise the box even further and...
								// it will continue waiting frame-by-frame until the box reaches its destination in height.
								// At this point: it exits the foreach loop cycle, returns back to the same foreach cycle for the next box to enter (if it meets condition)
								// Repeats that process for each and every box (4) so that each box rises in sequence
						}
		}
		yield return new WaitForSeconds (1.0f); // Waits for a further 1 second and...
		Debug.Log("Sequence Completed"); // then prints string message.
	}
	
	// Use this for initialization
	void Start ()
	{
		StartCoroutine (MoveBoxes()); // The proper convention, syntax for calling our coroutine
	}
	// Update is called once per frame
	void Update () 
	{
	}
}



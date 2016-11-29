using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
	// Create a boolean value called "locked" that can be checked in Update()

	bool locked = true;
	bool keyCollected = false;
	public AudioSource clip_lock;
	public AudioSource clip_unlock;

	public GameObject sign;

	void Update ()
	{
		// If the door is unlocked and it is not fully raised
		// Animate the door raising up

		if (locked == false && keyCollected == true) {
			if (transform.position.y < 25f) {
				transform.Translate (0, 5f * Time.deltaTime, 0, Space.World);
			} else {
				sign.SetActive (true);
			}


		}  
			 
	}

	public void Unlock ()
	{
		// You'll need to set "locked" to false here
		if (keyCollected == true) {
			locked = false;
			clip_unlock.Play ();
		} else {
			clip_lock.Play ();
		}

	}

	public void keyClicked ()
	{
		keyCollected = true;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
	//Create a reference to the KeyPoofPrefab and Door
	public GameObject keyRotation;
	public GameObject keyProof;
	public GameObject key;
	public bool keyCollected=false;


	void Update ()
	{
		//Bonus: Key Animation
		keyRotation.transform.Rotate (0f, 90 * Time.deltaTime, 0f);

	}

	public void OnKeyClicked ()
	{
		// Instatiate the KeyPoof Prefab where this key is located
		// Make sure the poof animates vertically
		// Call the Unlock() method on the Door
		// Destroy the key. Check the Unity documentation on how to use Destroy
		keyCollected = true;
		Destroy (key);
		GameObject _keyProof = (GameObject)Object.Instantiate (keyProof, key.transform.position, Quaternion.identity);
		_keyProof.transform.Rotate (-90f, 0f, 0f, Space.World);
		 
	}
 

}

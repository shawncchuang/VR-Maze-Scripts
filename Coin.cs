using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor.VersionControl;

public class Coin : MonoBehaviour
{
	//Create a reference to the CoinPoofPrefab
	public GameObject coinProof;
	public GameObject coin;

	public void OnCoinClicked ()
	{
		// Instantiate the CoinPoof Prefab where this coin is located
		// Make sure the poof animates vertically
		// Destroy this coin. Check the Unity documentation on how to use Destroy
		 
//
		GameObject _coinProof = (GameObject)Object.Instantiate (coinProof, coin.transform.position, Quaternion.identity);
		_coinProof.transform.Rotate(-90f, 0f, 0f, Space.World);
		Destroy (coin);
	}

}

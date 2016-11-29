using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;

public class SignPost : MonoBehaviour
{
	public GameObject sign;

	void Start ()
	{
		sign.SetActive (false);
	}

	public void ResetScene ()
	{
		// Reset the scene when the user clicks the sign post
		SceneManager.LoadScene ("Maze");
	}
}
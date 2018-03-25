using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Ustawieniemaila : MonoBehaviour {
	public static string email;
	// Use this for initialization
	public static InputField text;                      // Reference to the Text component.

	void Start()
	{
		

	}
	void Awake ()
	{
		// Set up the reference.
		text = GetComponent <InputField> ();

		// Reset the score.

	}


	void Update ()
	{
		Debug.Log (email);
		// Set the displayed text to be the word "Score" followed by the score value.
		email=text.text;

	}
}
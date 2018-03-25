using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ustawianieimienia : MonoBehaviour {
	public static string imie;
	// Use this for initialization
	public static InputField text;                  

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
		


		imie=text.text;

	
	
	}
}
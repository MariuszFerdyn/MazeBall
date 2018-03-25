using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TekstKoncowy : MonoBehaviour {
	Text text;     
	// Use this for initialization
	void Start () {
		
	}
	void Awake ()
	{

		// Set up the reference.
		text = GetComponent <Text> ();

		// Reset the score.;	
	}
	// Update is called once per frame
	void Update () {
		text.text = "Your Points " + ScoreController.count + "\n" +
		"Your Time " + Czaswgrze.CzasEksport + "\n";

			
	}
}

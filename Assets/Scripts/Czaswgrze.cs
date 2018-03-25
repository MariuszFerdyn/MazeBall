using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Czaswgrze : MonoBehaviour {
	public static int CzasEksport;
	public static float czas;
	public static bool STOP=true;

	Text text;                      // Reference to the Text component.

	void Start()
	{
		InvokeRepeating ("Czas", 0.0f, 0.01f);

	}
	void Awake ()
	{

		// Set up the reference.
		text = GetComponent <Text> ();

		// Reset the score.;	
	}
	void Czas(){
		if (STOP == false) {
			czas += 0.01f;
		}
	}

	void Update ()
	{
		CzasEksport = (int)czas;

		czas = Mathf.Round(czas * 100f) / 100f;
		text.text = "Time " +czas;
	}
}
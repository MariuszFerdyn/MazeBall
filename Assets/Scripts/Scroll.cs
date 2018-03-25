using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroll : MonoBehaviour {
    
	public static bool scroll=false;
    Text text;
	public Transform newPosition;
    public static int x = 0;
	RectTransform trans;
	// Use this for initialization
	void Start () {
		trans = GetComponent<RectTransform>();
	}
    void Awake()
    {

        // Set up the reference.
        text = GetComponent<Text>();

        // Reset the score.;	
    }
    // Update is called once per frame
    void Update () {

        if (x == 1)
        {
            text.text = "Your score has been sent to https://mazeball.azurewebsites.net/ - remember you can Win 100 USD. This music comes from Demo Enigma by Phenomena (Amiga demogroup). The title Popcorn music comes from old Polish royalty free service like mp3.wp.pl. Go Ahead!";
        }
        if (x == 2)
        {
            text.text = "As usual  your score has been sent to https://mazeball.azurewebsites.net/ - please visit to see your results or donate this work! You can find more my activity at https://mvp.microsoft.com/en-us/PublicProfile/5002168?fullName=Mariusz%20%20Ferdyn source code of this game also will be provided.";
        }
        if (x == 3)
        {
            text.text = "As usual  your score has been sent to https://mazeball.azurewebsites.net/ ! Try to reach better result – just play again and try to win 100 USD.";
        }
		Debug.Log (x);
		if (scroll == true) {
			transform.Translate (-250f * Time.deltaTime, 0f, 0f);
		}
		if (transform.position.x < -6000) {
			this.transform.position = newPosition.position;
            ScrollingText.permission = true;
			scroll = false;

		}
	}
}


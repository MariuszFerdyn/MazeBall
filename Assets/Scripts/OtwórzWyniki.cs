using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtwórzWyniki : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void OpenURL (string url) {
		Application.OpenURL (url);
	}
}

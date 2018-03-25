using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingText : MonoBehaviour {
	public static bool scroll=false;
    public static bool permission = false;
	public Transform newPosition;
	RectTransform trans;
	// Use this for initialization
	void Start () {
		trans = GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (transform.position.x);
		if (scroll == true&permission==true) {
			transform.Translate (-250f * Time.deltaTime, 0f, 0f);
		}
		if (transform.position.x < -6000) {
			this.transform.position = newPosition.position;
			scroll = false;
            permission = false;

		}
	}
}

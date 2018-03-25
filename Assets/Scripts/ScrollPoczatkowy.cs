using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollPoczatkowy : MonoBehaviour {
	public static bool scroll=true;
    public static bool destructor = false;
	public Transform newPosition;
	RectTransform trans;
	// Use this for initialization
	void Start () {
		trans = GetComponent<RectTransform>();
	}

	// Update is called once per frame
	void Update () {
        if (destructor == true)
        {
            Destroy(this.gameObject);
        }
		Debug.Log (transform.position.x);
		if (scroll == true) {
			transform.Translate (-250f * Time.deltaTime, 0f, 0f);
		}
		if (transform.position.x < -6000) {
            this.transform.position = newPosition.position;
            Scroll.scroll = true;
			scroll = false;

		}
	}
	void OnApplicationQuit()
	{
		scroll = true;
	}
	// Update is called once per frame
}
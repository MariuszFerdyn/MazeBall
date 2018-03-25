using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicChange : MonoBehaviour {
	public Animator anim;
	public static bool pozwolenie = false;
	// Use this for initialization
	void Start () {
		anim = GameObject.Find("GameObject (1)").gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (pozwolenie == true) {
			anim.Play ("PlayMusic");
			pozwolenie = false;
		}
	}
}

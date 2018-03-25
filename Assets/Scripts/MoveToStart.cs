using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToStart : MonoBehaviour {
	public Animator anim;
	public GameObject otherObject;
	// Use this for initialization
	
	
	// Update is called once per frame
	public void OnClick (string animacja) {
        Scroll.scroll = true;
        
        Scroll.x = 0;
        ScrollPoczatkowy.destructor = true;
        PlayerController.zgoda = true;
		Czaswgrze.STOP = false;
		MusicChange.pozwolenie = true;
		anim.Play (animacja);

	}
}

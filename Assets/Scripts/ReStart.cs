using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReStart : MonoBehaviour {
    public Animator anim;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	public void Click (string animacja) {
        Scroll.scroll = true;

        Czaswgrze.czas = 0;
        Scroll.x = 0;
        ScrollPoczatkowy.destructor = true;
        PlayerController.zgoda = true;

        MusicChange.pozwolenie = true;
        anim.Play(animacja);
    }
}

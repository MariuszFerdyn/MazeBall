using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPlay : MonoBehaviour {
	public Animator anim;
	public string Tag;
	// Use this for initialization
	void Start () {
		anim = GameObject.Find("MainCamera").gameObject.GetComponent<Animator>();
	}

	
	// Update is called once per frame
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag(Tag))
		{
			anim.Play ("konie");
		}
	}
}

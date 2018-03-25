using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToEndText : MonoBehaviour {
	public string Tag;
	public Rigidbody rb;
	public Animator anim;
	public Transform newPosition;
	// Use this for initialization

		


		void OnTriggerEnter(Collider other)
		{
			if (other.CompareTag(Tag))
			{
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
			this.transform.position = newPosition.position;
			Czaswgrze.STOP = true;
			anim.Play ("MoveCameraToEnd");
			}
		}
	
	}

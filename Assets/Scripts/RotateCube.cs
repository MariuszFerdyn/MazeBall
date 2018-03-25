using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour {

    //zmienne
   public int RotateSpeed;





	// Use this for initialization
	void Start () {
        Debug.Log("Hello World");
        
	}
	
	// Update is called once per frame
	void Update () {
      
        transform.Rotate(Vector3.up * RotateSpeed);

    }
}

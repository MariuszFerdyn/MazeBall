using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XboxController : MonoBehaviour {
	public static bool zgoda = false;
	public Rigidbody rb;
	public Animator anim;

	// ______ZMIENNE__________


	//Zmienna mowiaca z jaką predkoscia chcemy poruszac sie graczem
	public    int speed = 20;

	//Zmienna w ktorej przechowujemy nasz komponent Rigidbody
	Rigidbody rigidBody;




	void Start(){
		
		rigidBody = GetComponent<Rigidbody>();
	}

	//Funkcja Update() uruchamiana jest co klatke gry
	void Update ()
	{

		Vector3 inputDirection = Vector3.zero;
		
			float moveHorizontal = Input.GetAxis ("XboxHorizontal");
			
			float moveVertical = Input.GetAxis ("XboxVertical");


			
			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);


			rb.AddForce (movement * speed);
		if (Input.GetButton ("Abutton")) {
			Scroll.scroll = true;
			Scroll.x = 0;
			ScrollPoczatkowy.destructor = true;
			PlayerController.zgoda = true;
			Czaswgrze.STOP = false;
			MusicChange.pozwolenie = true;
			anim.Play ("MoveCameraToStart");


		}
		if (Input.GetButton ("Xbutton")){
			Application.Quit();
	}
	if(Input.GetButton ("Ybutton"))
	{
		Application.OpenURL ("http://mazeball.azurewebsites.net/ ");	
	}

}
}

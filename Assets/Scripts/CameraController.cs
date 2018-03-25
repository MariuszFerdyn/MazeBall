using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	// zmienna z naszym graczem za ktorym bedzie podążać kamera
	private GameObject player;

	// tutaj zapiszemy miejsce w jakim kamera znajduje sie od gracza
	private Vector3 offset;

	// funckja Start() uruchamiana jest na poczatku gry
	void Start ()
	{
        //szukamy naszego gracza. wiemy ze ma component PlayerController jak jedyny na scenie wiec mozemy wyszukac ten component i potem wziac GameObject do jakiego jest podpiety
        player = GameObject.FindObjectOfType<PlayerController>().gameObject;

		// odejmujemy pozycje kamery od pozycji gracza aby wiedziec w jakiej odleglosci ma byc
		offset = transform.position - player.transform.position;
	}

	// funkcja Update() uruchamniana jest co klatke gry
	void LateUpdate ()
	{
		// ustwiamy pozycje kamery jako pozycja gracza + odlegosc jaka zapisalismy
		transform.position = player.transform.position + offset;
	}
}
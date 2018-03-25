
//Tutaj są importowane różne biblioteki. W nich zapisanych jest dużo skryptów z których możemy korzystać
using UnityEngine;
using System.Collections;


//Tutaj jest nazwa naszej Klasy
public class PlayerController : MonoBehaviour {
	public static bool zgoda = false;
	public Rigidbody rb;

    // ______ZMIENNE__________


    //Zmienna mowiaca z jaką predkoscia chcemy poruszac sie graczem
public    int speed = 20;

    //Zmienna w ktorej przechowujemy nasz komponent Rigidbody
    Rigidbody rigidBody;



    //_____FUNKCJE_______
    

    //Funkcja Start() uruchamiana jest jedynie na poczatku jak nasz obiekt jest aktywny
    void Start() {

        //szukamy w obiekcie do którego podpiety jest nasz skrypt komponentu Rigidbody i zapisujemy go w zmiennej
        rigidBody = GetComponent<Rigidbody>();
    }

    //Funkcja Update() uruchamiana jest co klatke gry
    void Update ()
	{
		if (SystemInfo.deviceType == DeviceType.Desktop&zgoda==true) {
			// Klasa Input pozwala nam dowiedzieć się czy gracz naciska jakieś klawisze
			//to zmienna w ktorej zapisujemy czy gracz nacinsal lewa lub prawa strzalke. Mowi nam o tym funkcja GetAxis("Horizontal")
			float moveHorizontal = Input.GetAxis ("Horizontal");
			//a tu sprawdzamy czy nacisnal strzlake w gore lub w dol
			float moveVertical = Input.GetAxis ("Vertical");
			//kiedy juz wiemy jakie strzalki zostaly nacisniete zapisujemy to jako Vector3 aby uzyc tego jako sily dzilajacej na gracza. Y w Vectorze3 jest 0 bo nie chcemy aby gracz poruszal sie w gore lub dol
			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		

			rb.AddForce (movement * speed);
		} else if(zgoda==true) {
			
			float	moveHorizontal = Input.acceleration.x;
			float moveVertical = Input.acceleration.y;                        
			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
			rb.AddForce (movement * speed * 2);
		}
	}
}


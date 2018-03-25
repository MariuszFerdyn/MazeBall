using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnPlayerAfterFall : MonoBehaviour {

    //spawn point - nasze miejsce gdzie bedziemy chcieli ustawic gracza po tym jak spadnie
    public Transform spawnPoint;

    //prywatna zmienna przechowujaca Rigidbody
    private Rigidbody rigidbody;

    private void Start() {
        // szukamy w GameObjecie do ktorego jest podpiety skrpyt componentu Rigidbody abysmy mogli go uzyc
        rigidbody = GetComponent<Rigidbody>();
    }

    // Funkcja OnTriggerEnter jest wywoływana w momencie kiedy zderzymy sie z jakims obiektem co ma zaznaczone "isTrigger". 
    // Obiekty ktore są Triggerami nie oddzialuja na siebie fizycznie a jedynie dostajemy informacje ze "dotykaja sie"
    private void OnTriggerEnter(Collider other) {

        //sprawdzamy w co uderzyl nasz gracz. jezeli obiekt z ktorym sie zderzyl ma Tag "Game Area" to znaczy ze spadł i dotknal naszego collidera pod plansza
        if (other.CompareTag("GameArea")) {
            //ustawiamy pozycje gracza na pozycje naszego spawn pointu
            this.transform.position = spawnPoint.position;

            //ustawiamy przyspieszenie gracza na zero. Chcemy żeby po resecie stał w miejscu a nie leciał gdzieś dalej
            rigidbody.velocity = Vector3.zero;

        }
    }
}

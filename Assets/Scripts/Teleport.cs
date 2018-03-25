using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {
	public string Tag;
    public Transform newPosition;

	public static string url;
	public void Start () {





	}

	public static IEnumerator WaitForRequest()
	{
		Debug.Log (url);
		WWW www = new WWW(url);
		yield return www;

		// check for errors
		if (www.error == null)
		{
			Debug.Log("Przesyłanie danych powiodło się: " + www.text);
		} else {
			Debug.Log("Przesyłanie danych nie powiodło się z powodu: "+ www.error);
		}    
	}   



    void OnTriggerEnter(Collider other)
    {
		if (other.CompareTag(Tag))
        {
            Scroll.x += 1;
			Scroll.scroll = true;
			url = "https://mazeballscores.azurewebsites.net/api/HttpTriggerCSharp/"+Ustawianieimienia.imie+"/"+Czaswgrze.CzasEksport+"/"+ScoreController.count+"/"+SystemInfo.deviceType+"/"+Ustawieniemaila.email+"?code=UuRooI3mYMa3v1vS3JzP92jDE9xedKExi6las4YmBl8RqA/Wjr9CJg==";
			StartCoroutine (WaitForRequest ());
            this.transform.position = newPosition.position;
        }
    }
	void Update()
	{
		Debug.Log (url);
	}
}

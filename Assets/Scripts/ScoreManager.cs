using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour {

	public static int score;
    public Text scoreText;
     public Text winText;

	// Use this for initialization
	void Start () {
        score = 0;
        scoreText.text = "punkty " + score;
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void OnTriggerEnter(Collider other)
    {
        score += 1;
        scoreText.text = "punkty " + score;
        Destroy(other.gameObject);
      
    }





}




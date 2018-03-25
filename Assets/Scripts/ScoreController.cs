using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public Text countText;
    public Text winText;

	public static int count;
    public int PointsToWin;

    // Use this for initialization
    void Start () {

        // Set the count to zero 
        count = 0;

        // Run the SetCountText function to update the UI (see below)
       

        // Set the text property of our Win Text UI to an empty string, making the 'You Win' (game over message) blank
     



    }


    private void OnTriggerEnter(Collider other) {
        // ..and if the game object we intersect has the tag 'Pick Up' assigned to it..
        if (other.gameObject.CompareTag("Pick Up")) {
            // Make the other game object (the pick up) inactive, to make it disappear
            other.gameObject.SetActive(false);

            // Add one to the score variable 'count'
            count = count + 1;

            // Run the 'SetCountText()' function (see below)
          
        }
    }

    // Create a standalone function that can update the 'countText' UI and check if the required amount to win has been achieved
    void Update() {
        // Update the text field of our 'countText' variable
        countText.text = "Score: " + count.ToString();

        // Check if our 'count' is equal to or exceeded 12
       
    }
}

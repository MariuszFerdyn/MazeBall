using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public Vector3 respawnPoint;
    Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -100)
        {
            ResetPosition();
        }

    }

    void ResetPosition()
    {
        Scroll.x = 0;
		Czaswgrze.czas = 0;
		ScoreController.count = 0;
        transform.position = respawnPoint;
        rb.velocity = Vector3.zero;
    }
}


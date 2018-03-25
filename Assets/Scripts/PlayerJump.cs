using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    //zmienne
    bool isOnGround;
    public int JumpHeight;
    Rigidbody rb;




    // Use this for initialization
    void Start()
    {
        //DODAC TO
        rb = GetComponent<Rigidbody>();





    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isOnGround)
            {

                rb.AddForce(Vector3.up * JumpHeight);
                isOnGround = false;
            }
        }
       
    }


    void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}



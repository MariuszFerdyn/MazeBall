using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayAwake : MonoBehaviour {

    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

    }

    // Update is called once per frame
    void Update () {
		
	}
}

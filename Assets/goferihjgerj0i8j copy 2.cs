using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepScrene : MonoBehaviour {

	// Use this for initialization
	void Start () {

        // Disable screen dimming
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

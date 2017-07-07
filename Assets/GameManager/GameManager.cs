using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {
    public bool recording = true;
	// Use this for initialization
    
	
	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButton("Fire1"))
        {
            recording = false;
            Debug.Log("recording is OFF");
        }
        else
        {
            recording = true;
        }
	}
}

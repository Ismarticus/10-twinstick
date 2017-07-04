using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {
    private bool recording;
	// Use this for initialization
	void Start () {
        recording = true;
	}
	
	// Update is called once per frame
	void Update () {
		while (CrossPlatformInputManager.GetButton("Fire1"))
        {
            recording = false;
            Debug.Log("recording is OFF");
        }
	}
}

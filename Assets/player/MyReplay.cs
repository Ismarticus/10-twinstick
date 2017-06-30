using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyReplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

// Building my own class. 
public class MyKeyFrame 
{

    private float frameTime;
    private Vector3 pos;
    private Quaternion rot;
    //constructor
    public MyKeyFrame(float kt, Vector3 apos, Quaternion arot)
    {
        frameTime = kt;
        pos = apos;
        rot = arot;
    }
}
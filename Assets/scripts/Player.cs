using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class Player : MonoBehaviour {
    public float MovZ;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Working on building a move horizontal method. 
        Debug.Log(Input.GetAxisRaw("Horizontal"));
        if(CrossPlatformInputManager.GetAxisRaw("Horizontal") == 1f)
        {
            this.transform.Translate(CrossPlatformInputManager.GetAxisRaw("Horizontal") * 0, 0, MovZ * Time.deltaTime);
        }
        if(CrossPlatformInputManager.GetAxisRaw("Horizontal") == -1f)
        {
            this.transform.Translate(CrossPlatformInputManager.GetAxisRaw("Horizontal") * 0, 0, -MovZ * Time.deltaTime);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class Player : MonoBehaviour {
    //setting a float so I can control the speed of the movement from the unity gui.
    public float MovZ;

	// Use this for initialization
	void Start () {
		
	}

    // This also works.  This time however there is a small delay for the "gravity" settings.  This has a neat effect like a thruster.
    void Update()
    {
        //Working on building a move horizontal method. 
        Debug.Log(Input.GetAxis("Horizontal"));
        if (CrossPlatformInputManager.GetAxis("Horizontal") == 1f)
        {
            this.transform.Translate(CrossPlatformInputManager.GetAxisRaw("Horizontal") * 0, 0, MovZ * Time.deltaTime);
        }
        if (CrossPlatformInputManager.GetAxis("Horizontal") == -1f)
        {
            this.transform.Translate(CrossPlatformInputManager.GetAxisRaw("Horizontal") * 0, 0, -MovZ * Time.deltaTime);
        }
    }
    // Update is called once per frame
    /*void Update () {
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
    }*/

}

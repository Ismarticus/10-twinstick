using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// I want the camera to follow the ball.  Not that this is my favorite project but it is something worth learning from.
public class GameCamera : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        //player = GameObject.FindObjectOfType<Player>();
        offset = transform.position - player.transform.position;
	}
	
	// like update just later.
	void LateUpdate () {
        
        transform.position = player.transform.position + offset;
	}
}

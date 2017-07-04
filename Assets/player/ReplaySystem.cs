using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ReplaySystem : MonoBehaviour
{
    private const int bufferFrames = 100;
    private MyKeyFrame[] keyFrames = new MyKeyFrame [bufferFrames];

    private Rigidbody rigidBody;

    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        int frame = Time.frameCount % bufferFrames;
        float time = Time.time;
        print("writing frame " + frame);
        keyFrames[frame] = new MyKeyFrame(time, transform.position, transform.rotation);
    }
    void PlayBack()
    {
        rigidBody.isKinematic = true;
        int frame = Time.frameCount % bufferFrames;
        print("reading frome" + frame);
        transform.position = keyFrames[frame].pos;
        transform.rotation = keyFrames[frame].rot;
    }


}



/// <summary>
/// A class for storing playback info.
/// </summary>

// Building my own class. 
public class MyKeyFrame
{

    public float frameTime;
    public Vector3 pos;
    public Quaternion rot;
    //constructor
    public MyKeyFrame(float kt, Vector3 apos, Quaternion arot)
    {
        frameTime = kt;
        pos = apos;
        rot = arot;
    }
}
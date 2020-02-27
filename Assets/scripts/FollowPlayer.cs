using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform playercamera;
    public Vector3 offset; // special variable which store 3 numbers x,  y & z
    public float smoothspeed = 0.125f; // variable use to lockon target smoothly. higher the value faster will be locked on the target

	// Update is called once per frame
    
    //LateUpdate: call after everything else
 
    void FixedUpdate() // Code for more smooth camera follow
    {
        Vector3 Desiredposition = playercamera.position + offset;
        Vector3 smoothedposition = Vector3.Lerp(transform.position, Desiredposition, smoothspeed);
        transform.position = smoothedposition;

        transform.LookAt(playercamera);
    }

	/*void Update () {
        //Debug.Log(playercamera.position); //to print position of player on console

        // transform with a small 't' refere to the transform of the current object
        transform.position = playercamera.position + offset;
	}*/
}

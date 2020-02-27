using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class playercollision : MonoBehaviour {

    public PlayerMovement movement;
	void OnCollisionEnter( Collision collisioninfo)
    {
        if( collisioninfo.collider.tag == "obsticle" ){
            FindObjectOfType<audiomanager>().play("BrickCollsion"); // call the function to play the sound
            CameraShaker.Instance.ShakeOnce(3f, 3f, .1f, 1f);
            movement.enabled = false;
            FindObjectOfType<manager>().EndGame();
        }
    }
}

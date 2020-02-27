using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;    
public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public ThirdPersonCharacter character;
    public Transform Player;
    public float forwardforce = 1000f;
    private Animator anim;
    public float sidewaysforce = 90f;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        // Debug.Log("Hello,World" );   // output at console
        // rb.useGravity = false;
        // rb.AddForce(100, 200, 500);
	}
	
	// Update is called once per frame
    // Unity prefered FixedUpdate more to mess with physics
	void FixedUpdate () {
        anim.SetFloat("Turn", 0);

        anim.SetFloat("Forward", forwardforce * Time.deltaTime);
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        int jumpHash = Animator.StringToHash("Locomotion");

        if (Input.GetKey("d")) //not efficent way for jumping, adding alternative keys, smooth movement, adding controller - unity got more good ways to handle these problems
        {
            anim.SetFloat("Turn", sidewaysforce * Time.deltaTime);
            rb.AddForce(sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            anim.SetFloat("Turn", -sidewaysforce * Time.deltaTime);

            rb.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //if (Input.GetKey("w"))
        //{
        //    rb.AddForce(0, 20 * Time.deltaTime, 0, ForceMode.VelocityChange);
        //}
        
        //character.Move()

        if (rb.position.y < -1)
        {
            anim.SetBool("OnGround", false);
            FindObjectOfType<manager>().EndGame();
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 8f;
	public float maxVelovity = 4f;

	private Rigidbody2D myBody;
	private Animator anim;

	void Awake() {
		myBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> (); 
	}



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		PlayerMoveKeyboard ();
	}

	void PlayerMoveKeyboard() {
		float forceX = 0f;
		float vel = Mathf.Abs (myBody.velocity.x);

		float h = Input.GetAxisRaw ("Horizontal");

		if (h > 0) {
		
			if (vel < maxVelovity)
				forceX = speed; 

		} else if (h < 0) {

			if (vel < maxVelovity)
				forceX = -speed; 
		
		}
		  
		myBody.AddForce (new Vector2(forceX, 0));
		 


	} 




}
//Player
















































using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour {

	public CharacterController charControl;
	public Vector3 moveVector3;
	public float gravity = 9.81f, speed = 5f;
	Animator animator;
	public bool moveSideways = false;

	void Start(){
		animator = GetComponent<Animator>();
	}

	void Update () {
		if (Input.GetAxis ("Horizontal") != 0f) {
			moveSideways = true;
		} 
		else {
			moveSideways = false;
		}
		//have key input affect V3
		moveVector3.x = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
		moveVector3.z = Input.GetAxis ("Vertical") * speed * Time.deltaTime;

		//make gravity affect v3
		//if !!grounded gravity -y, when grounded don't -y & v3=0
		if (!charControl.isGrounded){
			moveVector3.y -= gravity * Time.deltaTime;
		}
		//have V3 changes affect the assigned character controller
		charControl.Move (moveVector3);
		//tells animator PC is moving
		animator.SetBool ("hMove", moveSideways);
	}
}

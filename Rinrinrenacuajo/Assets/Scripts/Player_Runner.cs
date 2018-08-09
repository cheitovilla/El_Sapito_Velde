using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Runner : MonoBehaviour {

	public float moveSpeed;
	public float jumpForce;

	private Rigidbody2D myRigibody;

	public bool grounded;
	public LayerMask whatIsGround;

	private Collider2D myCollider;
	private Animator anim;

	// Use this for initialization
	void Start () {
		myRigibody = GetComponent<Rigidbody2D> ();
		myCollider = GetComponent<Collider2D>();
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		grounded = Physics2D.IsTouchingLayers (myCollider, whatIsGround);

		myRigibody.velocity = new Vector2 (moveSpeed, myRigibody.velocity.y);

		if (Input.GetKeyDown(KeyCode.Space)) {
			if (grounded) {
				anim.SetTrigger ("Jumping");
				myRigibody.velocity = new Vector2 (myRigibody.velocity.x, jumpForce);

			}

		}

	}
}

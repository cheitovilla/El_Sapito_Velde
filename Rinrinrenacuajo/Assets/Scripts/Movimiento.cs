﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

	//variables de movimiento
	public float velX = 0.1f;
	public float movX;
	public float posicionActual;

	//vriables de salto
	public float fuerzaSalto = 300f;
	public Transform pie;
	public float radioPie;
	public LayerMask suelo;
	public bool enSuelo;

	//Animaciones
	Animator animator;

	void Awake(){
		animator = GetComponent<Animator> ();
	
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//Debug.Log (transform.position.x);
		float inputX = Input.GetAxis ("Horizontal"); // Se mueve en el eje x


		if (inputX > 0) {
			movX = transform.position.x + (inputX * velX);
			transform.position = new Vector3 (movX, transform.position.y, 0);
			transform.localScale = new Vector3 (1, 1, 1);
			movX = posicionActual;

		}
		if (inputX < 0) {
			movX = transform.position.x + (inputX * velX);
			transform.position = new Vector3 (movX, transform.position.y, 0);
			transform.localScale = new Vector3 (-1, 1, 1);
			movX = posicionActual;
		
		}

		if (inputX != 0 && enSuelo) {
			animator.SetFloat ("velX", 1);
		}
			else {
				animator.SetFloat("velX", 0);
			}



		//Salto

		enSuelo = Physics2D.OverlapCircle (pie.position, radioPie, suelo);
		if (enSuelo) {
			animator.SetBool ("enSuelo", true);
		} else {
			animator.SetBool ("enSuelo", false);
		}
		if ( enSuelo && Input.GetKeyDown(KeyCode.Space)) {
			GetComponent <Rigidbody2D>().AddForce (new Vector2(0,fuerzaSalto));
			animator.SetBool ("enSuelo", false);
		}
	}


	void OnCollisionEnter2D(Collision2D other){
		if (other.transform.tag == "Move") {
			transform.parent = other.transform;
		}
	}

	void OnCollisionExit2D(Collision2D other){
		if (other.transform.tag == "Move") {
			transform.parent = null;
		}
	}

}

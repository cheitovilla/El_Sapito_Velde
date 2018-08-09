using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour {

	//public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//void OnCollisionEnter2D(Collision2D other){
	//	if (other.gameObject.tag == "Obstaculo") {
	//		transform.position = new Vector3 (0f, transform.position.y);

	//	}
	//}

	void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "Obstaculo") {
			transform.position = new Vector3 (0f, -3.62f);
		}
	}


}

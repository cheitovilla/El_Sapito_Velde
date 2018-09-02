using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovemmentCamera : MonoBehaviour {

//	public Transform target; //A que objeto debe seguir la camara.
//	public float xOffset; //offset de la camara respecto del target en el eje x.
//	public float yOffset; //	" 		" 		"  		"		"	en el eje y.
//	public float zOffset;

	public Player_Runner thePlayer;
	private Vector3 lastPlayerPosition;
	private float distancetoMove;

	void Start(){
		thePlayer = FindObjectOfType<Player_Runner> ();
		lastPlayerPosition = thePlayer.transform.position;
	}


	void Update(){
		distancetoMove = thePlayer.transform.position.x - lastPlayerPosition.x;
		transform.position = new Vector3 (transform.position.x + distancetoMove, transform.position.y, transform.position.z);
		lastPlayerPosition = thePlayer.transform.position;


		if (transform.position.x> 740) {
			transform.position = new Vector3 (740, transform.position.y,transform.position.z);
		}
	}


	// Update is called once per frame
	void FixedUpdate () {
		//transform.position = new Vector3 (zOffset, yOffset, target.position.z - xOffset);
	}
}

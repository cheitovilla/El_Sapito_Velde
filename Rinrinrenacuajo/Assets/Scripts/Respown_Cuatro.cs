using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respown_Cuatro : MonoBehaviour {
	//llega hasta 1030 en x
	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player.transform.position.x < -4.7)
		{
			player.transform.position = new Vector3(-4.7f, player.transform.position.y);
		}
		if (player.transform.position.x>772) {  //475
			SceneManager.LoadScene ("Historia_Final");
		}
	}
}

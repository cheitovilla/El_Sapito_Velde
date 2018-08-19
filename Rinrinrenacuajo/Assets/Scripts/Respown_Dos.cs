using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respown_Dos : MonoBehaviour {

	public GameObject player;
	public GameObject player2;
	public GameObject history3;
	public AudioSource audio3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player.transform.position.x < -4.7)
		{
			player.transform.position = new Vector3(-4.7f, player.transform.position.y);
		}
		if (player2.transform.position.x < -4.7)
		{
			player2.transform.position = new Vector3(-4.7f, player2.transform.position.y);
		}

		if (player2.transform.position.x < player.transform.position.x +4) {
			player2.transform.position = new Vector3 (player.transform.position.x - 2.5f, player2.transform.position.y);
		}



//		if (player.transform.position.x >= 230) {
//			TerceraScena ();
//		//	SceneManager.LoadScene ("Scene3");
//		}
	}



	public void Nextscene()
	{
		SceneManager.LoadScene ("Scene3");
		//Time.timeScale = 1;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respown_Tres : MonoBehaviour {

	public GameObject player;
	public GameObject infoText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player.transform.position.x < -4.7)
		{
			player.transform.position = new Vector3(-4.7f, player.transform.position.y);
		}

		if (player.transform.position.x >= 173)
		{
			player.transform.position = new Vector3 (173f, player.transform.position.y);
			infoText.SetActive (true);
		} 
		else 
		{
			infoText.SetActive (false);
		}


//		if (player.transform.position.x>175) {  
//			SceneManager.LoadScene ("Scene4");
//		}
	}


	public void Nextscene()
	{
		SceneManager.LoadScene ("Scene4");
		//Time.timeScale = 1;
	}
}

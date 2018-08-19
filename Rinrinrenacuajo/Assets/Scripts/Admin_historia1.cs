using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Admin_historia1 : MonoBehaviour {

	public GameObject Panel_historia;
	public GameObject button_historia;
	public AudioSource audio_historia;
	public GameObject player;
	public bool historia;

	// Use this for initialization
	void Start () 
	{
		historia = true;
		audio_historia.Play ();
		button_historia.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (historia == true)
		{
			Time.timeScale = 0;
		} 
		else 
		{
			Time.timeScale = 1;
		}
		if (player.transform.position.x >= 230) {
			Time.timeScale = 0;
		}
	}


	public void ShowHistory()
	{
		Panel_historia.SetActive (true);
		historia = true;
		audio_historia.Play ();
		button_historia.SetActive (false);
	}

	public void CloseHistory()
	{
		Panel_historia.SetActive (false);
		historia = false;
		audio_historia.Stop ();
		button_historia.SetActive (true);
		Panel_historia.SetActive (false);
	}
}

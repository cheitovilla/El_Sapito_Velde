using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Admin_Historias : MonoBehaviour {
	//1366 * 768

	public GameObject panel_historia;
	public GameObject button_historia;
	public AudioSource audio_historia2;
	public GameObject text2;
	public bool historia;

	// Use this for initialization
	void Start () {
		historia = true;
		button_historia.SetActive (false);
		audio_historia2.Play ();
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
	}

	public void ShowHistory(){
		panel_historia.SetActive (true);
		historia = true;
		button_historia.SetActive (false);
		audio_historia2.Play ();

	}

	public void CloseHistory(){
		panel_historia.SetActive (false);
		historia = false;
		audio_historia2.Stop ();
		button_historia.SetActive (true);
	}


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Admin_historias_Tres : MonoBehaviour {

	Animator anim_papiro;
	public GameObject panel_historia;
	public GameObject button_historia;

	public GameObject buttonToHistory2;
	//------------------
	public AudioSource audio_historia2;
	public GameObject text2;
	public GameObject buttonToHistory3;
	//------------------
	public AudioSource audio_historia3;
	public GameObject text3;
	public GameObject buttonBackHistory2;

	public bool historia;
	public GameObject player;
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
		if (player.transform.position.x >= 171.5 && FindObjectOfType<Recoleccion>().count >= 360) {
			FindObjectOfType<Recoleccion>().panel_3.SetActive (true);
			FindObjectOfType<Recoleccion>().buttonH.SetActive (false);
			Time.timeScale = 0;
		}
	}

	public void ShowHistoryScene3(){
		historia = true;
		panel_historia.SetActive (true);
		text2.SetActive (true);
		text3.SetActive (false);

		button_historia.SetActive (false);
		buttonToHistory3.SetActive (true);

		audio_historia2.Play ();
		audio_historia3.Stop ();

	}

	public void CloseHistoryScene3(){
		historia = false;
		audio_historia2.Stop ();
		audio_historia3.Stop ();
		button_historia.SetActive (true);
		panel_historia.SetActive (false);
	}



	public void NextHistoryThree(){
		text2.SetActive (false);
		text3.SetActive (true); //activo text3

		buttonToHistory2.SetActive (false);
		buttonToHistory3.SetActive (false);
		buttonBackHistory2.SetActive(true);

		audio_historia2.Stop ();
		audio_historia3.Play ();
	}

	public void BackToHistoryTwo(){
		text2.SetActive (true); //activo text2
		text3.SetActive (false); 

		buttonToHistory2.SetActive (false);
		buttonToHistory3.SetActive (true);
		buttonBackHistory2.SetActive (false);

		audio_historia2.Play ();
		audio_historia3.Stop ();
	}


}

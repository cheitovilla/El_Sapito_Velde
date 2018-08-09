using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Admin_historias_Tres : MonoBehaviour {

	Animator anim_papiro;
	public GameObject panel_historia;
	public GameObject button_historia;

	public AudioSource audio_historia1;
	public GameObject tex1;
	public GameObject buttonToHistory2;
	//------------------
	public AudioSource audio_historia2;
	public GameObject text2;
	public GameObject buttonToHistory3;
	public GameObject buttonBackHistory1;
	//------------------
	public AudioSource audio_historia3;
	public GameObject text3;
	public GameObject buttonBackHistory2;

	// Use this for initialization
	void Start () {
		button_historia.SetActive (false);
		buttonBackHistory1.SetActive (false);
		anim_papiro = panel_historia.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowHistoryScene3(){
		tex1.SetActive (true);
		text2.SetActive (false);
		text3.SetActive (false);

		anim_papiro.SetBool ("sube", true);
		anim_papiro.SetBool ("baja", false);

		button_historia.SetActive (false);

		buttonToHistory2.SetActive (true);
		buttonToHistory3.SetActive (false);
		buttonBackHistory1.SetActive (false);
		buttonBackHistory2.SetActive (false);

		audio_historia1.Play ();
		audio_historia2.Stop ();
		audio_historia3.Stop ();

	}

	public void CloseHistoryScene3(){
		anim_papiro.SetBool("sube",false);
		anim_papiro.SetBool ("baja", true);
		audio_historia1.Stop ();
		audio_historia2.Stop ();
		audio_historia3.Stop ();
		button_historia.SetActive (true);
	}

	public void NextHistoryTwo(){
		tex1.SetActive (false);
		text2.SetActive (true); //activo text2
		text3.SetActive (false);

		buttonToHistory2.SetActive (false);
		buttonToHistory3.SetActive (true);
		buttonBackHistory1.SetActive (true);
		buttonBackHistory2.SetActive (false);

		audio_historia1.Stop ();
		audio_historia2.Play ();
		audio_historia3.Stop ();
	}

	public void BackToHistoryOne(){
		tex1.SetActive (true); //activo text1
		text2.SetActive (false);
		text3.SetActive (false);

		buttonToHistory2.SetActive (true);
		buttonToHistory3.SetActive (false);
		buttonBackHistory1.SetActive (false);
		buttonBackHistory2.SetActive (false);

		audio_historia1.Play ();
		audio_historia2.Stop ();
		audio_historia3.Stop ();
	}

	public void NextHistoryThree(){
		tex1.SetActive (false); 
		text2.SetActive (false);
		text3.SetActive (true); //activo text3

		buttonToHistory2.SetActive (false);
		buttonToHistory3.SetActive (false);
		buttonBackHistory1.SetActive (false);
		buttonBackHistory2.SetActive(true);

		audio_historia1.Stop ();
		audio_historia2.Stop ();
		audio_historia3.Play ();
	}

	public void BackToHistoryTwo(){
		tex1.SetActive (false); 
		text2.SetActive (true); //activo text2
		text3.SetActive (false); 

		buttonToHistory2.SetActive (false);
		buttonToHistory3.SetActive (true);
		buttonBackHistory1.SetActive (true);
		buttonBackHistory2.SetActive (false);

		audio_historia1.Stop ();
		audio_historia2.Play ();
		audio_historia3.Stop ();
	}


}

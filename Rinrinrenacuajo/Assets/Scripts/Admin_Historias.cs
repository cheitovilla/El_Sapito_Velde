using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Admin_Historias : MonoBehaviour {
	//1366 * 768

	public GameObject panel_historia;
	public GameObject button_historia;
	Animator anim_papiro;
	public AudioSource audio_historia;
	public AudioSource audio_historia2;
	public GameObject tex1;
	public GameObject text2;
	public GameObject button_sig;
	public GameObject button_atras;

	// Use this for initialization
	void Start () {
		button_historia.SetActive (false);
		button_atras.SetActive (false);
		//audio_historia.Play ();
		anim_papiro = panel_historia.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowHistory(){
		anim_papiro.SetBool ("sube", true);
		anim_papiro.SetBool ("baja", false);
		audio_historia.Play ();
		button_historia.SetActive (false);
		button_sig.SetActive (true);
		button_atras.SetActive (false);
		tex1.SetActive (true);
		text2.SetActive (false);

	}

	public void CloseHistory(){
		anim_papiro.SetBool("sube",false);
		anim_papiro.SetBool ("baja", true);
		audio_historia.Stop ();
		audio_historia2.Stop ();
		button_historia.SetActive (true);
	}

	public void NextHistory(){
		tex1.SetActive (false);
		text2.SetActive (true);
		button_sig.SetActive (false);
		button_atras.SetActive (true);
		audio_historia.Stop ();
		audio_historia2.Play ();
	}

	public void BackHistory(){
		tex1.SetActive (true);
		text2.SetActive (false);
		button_sig.SetActive (true);
		button_atras.SetActive (false);
		audio_historia2.Stop ();
		audio_historia.Play ();
	}

}

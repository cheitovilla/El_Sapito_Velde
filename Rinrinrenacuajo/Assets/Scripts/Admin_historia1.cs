using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Admin_historia1 : MonoBehaviour {

	public GameObject Panel_historia;
	public GameObject button_historia;
	public AudioSource audio_historia;
	Animator anim_papiro;

	// Use this for initialization
	void Start () {
		anim_papiro = Panel_historia.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowHistory(){
	//	anim_papiro.SetTrigger("showhistoria");
		anim_papiro.SetBool ("sube", true);
		anim_papiro.SetBool ("baja", false);
		audio_historia.Play ();
		button_historia.SetActive (false);
		//anim_papiro.SetTrigger("showhistoria");

	}

	public void CloseHistory(){
	//	anim_papiro.SetTrigger ("ocultarhistoria");
		anim_papiro.SetBool("sube",false);
		anim_papiro.SetBool ("baja", true);
		audio_historia.Stop ();
		button_historia.SetActive (true);
		//anim_papiro.SetTrigger("ocultarhistoria");
	}

}

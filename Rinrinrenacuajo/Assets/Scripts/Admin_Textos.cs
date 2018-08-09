using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Admin_Textos : MonoBehaviour {

	public AudioSource audio_click;
	public GameObject panel;
	Animator anim_papiro;
	// Use this for initialization
	void Start () {
		anim_papiro = panel.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowCredits(){
		anim_papiro.SetTrigger("show");
		audio_click.Play ();
	}

	public void extiCredits(){
		anim_papiro.SetTrigger ("ocultar");
		//anim_papiro.SetTrigger ("idle");
		audio_click.Play();
	}



}

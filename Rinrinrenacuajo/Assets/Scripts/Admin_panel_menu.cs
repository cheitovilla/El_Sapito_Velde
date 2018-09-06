using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Admin_panel_menu : MonoBehaviour {

	public GameObject panel_menu;
	Animator anim;


	// Use this for initialization
	void Start () 
	{
		anim = panel_menu.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ShowMenu()
	{
		anim.SetBool ("subemenu", true);
		anim.SetBool ("bajamenu", false);
	}

	public void CloseMenu()
	{
		anim.SetBool("subemenu",false);
		anim.SetBool ("bajamenu", true);
	}

	public void BackInicial()
	{
		SceneManager.LoadScene ("Main"); //Antes inicial ahora Main
	}

	public void QuitApp(){
		Debug.Log ("Me salí");
		Application.Quit ();
	}

	public void ScenaUno()
	{
		SceneManager.LoadScene ("Scene1");	
	}

	public void ScenaDos()
	{
		SceneManager.LoadScene ("Scene2");	
	}
	public void ScenaTres()
	{
		SceneManager.LoadScene ("Scene3");
	}


}

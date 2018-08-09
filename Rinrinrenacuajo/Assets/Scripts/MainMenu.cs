using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartMenu(){
		SceneManager.LoadScene("Main");

	}

	public void BackInicial(){
		SceneManager.LoadScene ("Inicial");
	}

	public void PlayGame(){
		SceneManager.LoadScene ("Scene1"); // te transporta a la escena 1
	}

	public void QuitApp(){
		Debug.Log ("Me salí");
		Application.Quit ();
	}
		


	public void Scene3(){
		SceneManager.LoadScene ("Scene3"); // La que recoje cerveza
	}
		

	public void SceneMenu(){
		SceneManager.LoadScene ("Main"); // La que se encuentra con el raton y siguen
	}
}

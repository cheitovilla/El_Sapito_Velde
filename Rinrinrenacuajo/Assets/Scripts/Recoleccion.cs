using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recoleccion : MonoBehaviour {

	public Text countText;
	public int count;
	public AudioSource audio_recoleccion;
	public GameObject panel_3;
	public AudioSource audio3;
	public GameObject buttonH;

	// Use this for initialization
	void Start () {
		count = 0;
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "Manzana") {
			//print ("no me quedo");
			Destroy (other.gameObject);
			count = count + 10;
			countText.text = count.ToString ();
			audio_recoleccion.Play ();
		}

		if (other.gameObject.tag == "Casa") {
			panel_3.SetActive (true);
			buttonH.SetActive (false);
			audio3.Play ();
			Time.timeScale = 0;
		//	Debug.Log ("Mk estoy colisionando!!!");
			Debug.Log (other.transform.position.x);
			//other.gameObject.SetActive (false);
			//audio.Play ();
		}
		if (other.gameObject.tag == "Afura") {
			panel_3.SetActive (true);
			buttonH.SetActive (false);
			audio3.Play ();
			Time.timeScale = 0;
			//other.gameObject.SetActive (false);
			//audio.Play ();
		}
	}



		



}

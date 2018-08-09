using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recoleccion : MonoBehaviour {

	public Text countText;
	public int count;
	public AudioSource audio_recoleccion;

	// Use this for initialization
	void Start () {
		count = 0;
		//audio = GetComponent<AudioSource> ();
	}

//	void OnCollisionEnter2D (Collision2D other){
//		if (other.gameObject.tag == "Manzana") {
//			print ("cojiendo");
//			count = count + 10;
//			other.gameObject.SetActive (false);
//			countText.text = count.ToString ();
//			audio.Play ();
//		}
//
//	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "Manzana") {
			print ("no me quedo");
			Destroy (other.gameObject);
			count = count + 10;
			countText.text = count.ToString ();
			audio_recoleccion.Play ();
		}
	}

		



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Respown : MonoBehaviour {


    public GameObject player;
	public GameObject textInfo;
  //  public Transform respown;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Si intenta ir atras
        if (player.transform.position.x < -4.7)
        {
			player.transform.position = new Vector3(-4.7f, player.transform.position.y);
        }
		//Si no recoje todas las manzanas, no pasa de niveel 1
		if (player.transform.position.x>236 && FindObjectOfType<Recoleccion>().count>=280) 
		{  
			SceneManager.LoadScene ("Scene2");
		}
		//Se activa text si llega al final del primer nivel y no recolecta todas las manzanas
		if (player.transform.position.x>=238)
		{  
			player.transform.position = new Vector3(238f, player.transform.position.y);
			textInfo.SetActive (true);
		} 
		// sino ,se desactiva
		else 
		{
			textInfo.SetActive (false);	
		}
    }


    
       
    
}

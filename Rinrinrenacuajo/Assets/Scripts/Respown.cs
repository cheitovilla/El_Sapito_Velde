using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respown : MonoBehaviour {


    public GameObject player;
  //  public Transform respown;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (player.transform.position.x < -4.7)
        {
			player.transform.position = new Vector3(-4.7f, player.transform.position.y);
        }
		if (player.transform.position.x>238) {  
			SceneManager.LoadScene ("Scene2");
		}
    }


    
       
    
}

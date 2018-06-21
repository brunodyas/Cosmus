using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D (Collider2D shot){

		if (shot.gameObject.tag == "cosmus" ||shot.gameObject.tag == "power" ) {

			Destroy (gameObject);	
		
		}

		if (shot.gameObject.tag == "pedra") {

			Destroy (gameObject);
		}
	}
}

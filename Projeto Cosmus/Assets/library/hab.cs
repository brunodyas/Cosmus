using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hab : MonoBehaviour {

	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D hab){

		if (hab.gameObject.tag == "cosmus") {

			Destroy (gameObject);

		}
	}

}

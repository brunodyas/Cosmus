using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fade : MonoBehaviour {

	SpriteRenderer FadeDestroy;

	Animator anima;

	// Use this for initialization

	void Start () {

		anima= GetComponent<Animator> ();
				
	}
	
	// Update is called once per frame
	void Update () {


		if (anima.GetCurrentAnimatorStateInfo(0).IsName("Destroy")) {
		
			Destroy (gameObject);
		}
	
	
	
	}
}

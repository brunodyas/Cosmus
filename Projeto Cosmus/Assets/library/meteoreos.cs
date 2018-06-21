using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteoreos : MonoBehaviour {

	public GameObject dirt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
				
	}

	void  OnCollisionEnter2D (Collision2D pedra){

		if (pedra.gameObject.tag == "cosmus") {

			Instantiate (dirt, transform.position, transform.rotation);

			SoundManager.Instance.EfxExplosion ();

			Destroy (gameObject);
		}

		if (pedra.gameObject.tag == "drone") {

			Instantiate (dirt, transform.position, transform.rotation);
			SoundManager.Instance.EfxExplosion ();
			Destroy (gameObject);
		}

	}

	void OnTriggerEnter2D (Collider2D pedra){
	
		if (pedra.gameObject.tag == "shot") {

			Instantiate (dirt, transform.position, transform.rotation);

			SoundManager.Instance.EfxExplosion ();

			Destroy (gameObject);
		}

		if (pedra.gameObject.tag == "power") {

			Instantiate (dirt, transform.position, transform.rotation);
			SoundManager.Instance.EfxExplosion ();
			Destroy (gameObject);
		}
	}
}


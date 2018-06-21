using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drone : MonoBehaviour {

	public float speed = -4f;
	public bool AutoDestroy = true;
	private bool ativo = false;
	public float time = 5.0f;
	public GameObject dirt;

		// Use this for initialization
	void Start () {
		
	}

	IEnumerator delay(float delaytime){
		yield return new WaitForSeconds (delaytime);
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed-10, 0);
		ativo = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (ativo == false && personagem.sleep == false) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, 0);
			StartCoroutine (delay (time));
		} 


		if (gameObject.transform.position.x <= -26 & AutoDestroy == true) {

			Destroy (gameObject);
		}
	}
		void  OnCollisionEnter2D (Collision2D drone){

			if (drone.gameObject.tag == "cosmus") {

				SoundManager.Instance.EfxExplosion ();	
				Destroy (gameObject);
				Instantiate (dirt, transform.position, transform.rotation);
			}

			if (drone.gameObject.tag == "platform") {

				SoundManager.Instance.EfxExplosion ();	
				Destroy (gameObject);
				Instantiate (dirt, transform.position, transform.rotation);
			}
	}

	void OnTriggerEnter2D (Collider2D drone){

		if (drone.gameObject.tag == "power") {
			SoundManager.Instance.EfxExplosion ();
			Destroy (gameObject);
			Instantiate (dirt, transform.position, transform.rotation);
		}

	}


		
}


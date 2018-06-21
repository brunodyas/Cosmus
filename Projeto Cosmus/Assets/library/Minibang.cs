using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minibang : MonoBehaviour {

	Animator animador;
	Rigidbody2D fisica;
	bool colidiu = false;
	bullet speed;
	// Use this for initialization
	void Start () {

		animador = GetComponent<Animator>();
		fisica = GetComponent<Rigidbody2D>();
		speed = GetComponent<bullet>();

	}
	
	// Update is called once per frame
	void Update () {

		if (colidiu == true) {

			fisica.bodyType = RigidbodyType2D.Kinematic;
			speed.speed = 0;

		}

		if (personagem.sleep == true) {

			animador.speed = 0f;
		
		}
		
	}

	void OnCollisionEnter2D (Collision2D  minibang){

		if (minibang.gameObject.tag == "cosmus") {

			animador.SetBool("caindo",true);
			SoundManager.Instance.EfxCollMiniBang ();
			colidiu = true;
		}
	}

	void OnTriggerEnter2D (Collider2D minibang){
			
		if (minibang.gameObject.tag == "power") {

			animador.SetBool("caindo",true);
			SoundManager.Instance.EfxCollMiniBang ();
			colidiu = true;
		}
	}
}

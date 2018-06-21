using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minifly : MonoBehaviour {

	float timeshot = 0.0f;
	Animator animador;
	public GameObject shot;
	Vector2 pos;



	// Use this for initialization
	void Start () {

		animador = GetComponent<Animator>();

		
	}

	// Update is called once per frame

	void FixedUpdate () {

		timeshot +=  0.1f;


		if (timeshot >= 15f && personagem.sleep == false) {

			animador.SetBool("shot", true);
			pos = new Vector2 (gameObject.transform.position.x -0.7f, gameObject.transform.position.y -0.2f);
			Instantiate (shot, pos, transform.rotation);
			timeshot = 0f;

		} else
			animador.SetBool("shot", false);
		
	
	
	}

	void OnTriggerEnter2D (Collider2D minibang){

		if (minibang.gameObject.tag == "cosmus") {

			animador.SetBool("col",true);
			SoundManager.Instance.EfxCollMiniBang ();

		}

		if (minibang.gameObject.tag == "power") {

			animador.SetBool ("col", true);
			SoundManager.Instance.EfxCollMiniBang ();

		}
	}

}

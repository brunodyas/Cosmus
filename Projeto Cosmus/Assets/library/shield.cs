using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour {

	Animator animador;	
	float cont = 0f;
	AudioSource Trilha;

	// Use this for initialization
	void Start () {

		Trilha = GetComponent<AudioSource> ();
		animador = GetComponent<Animator>();
}
	// Update is called once per frame
	void FixedUpdate () {

		cont += Time.deltaTime;
		
		if (cont >=6) {

			animador.SetBool ("end", true);

		}



		if (cont >=10) {

			Trilha.Stop ();
			Destroy (gameObject);
		
		}

		
	}

}

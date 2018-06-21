using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fases : MonoBehaviour {

	public static int OpenFase = 1;
	public static int EscFase = 1;
	public Sprite[] stage;
	SpriteRenderer acesso; 

	// Use this for initialization
	void Start () {
		acesso= GetComponent<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update () {
		
		if(OpenFase < EscFase ) {

			acesso.sprite = stage [0];
		
	}else
		
			if (EscFase == 1) {

			acesso.sprite = stage [EscFase];

		
			if (EscFase == 2) {

				acesso.sprite = stage [EscFase];

			}

		}
	}
}

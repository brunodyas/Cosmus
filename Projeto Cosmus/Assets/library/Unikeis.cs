using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unikeis : MonoBehaviour {

	public static int uniqueis_pacial = 0;
	public GameObject efeito;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (personagem.sleep == true) {
			Destroy (GameObject.FindWithTag("efeito"));
		
		}
	}

	void OnTriggerEnter2D (Collider2D money){

		if (money.gameObject.tag == "cosmus") {


			Instantiate (efeito, transform.position, transform.rotation);
			SoundManager.Instance.EfxUniqueis ();
			uniqueis_pacial++;
			Destroy (gameObject);
		}
	}
}

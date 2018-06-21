using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 
public class button : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}

	void OnMouseDown(){

		if (gameObject.tag == "bt_play") {

			if (fases.OpenFase >= fases.EscFase) {

				SceneManager.LoadScene ("stage" + fases.EscFase);
			}

		}

		if (gameObject.tag == "bt_esq") {

			if (fases.EscFase >= 2) {

				fases.EscFase--; 

			} else
				fases.EscFase = 1; 
			

		}if (gameObject.tag == "bt_dir"){

				if (fases.EscFase <= 9) {

				fases.EscFase ++;
			
				} else				

				fases.EscFase = 10;	
	
		}
}
	
	// Update is called once per frame
	void Update () {

				
	}


}

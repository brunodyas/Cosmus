using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class syslevel : MonoBehaviour {

	private float contador = 0f;
	static public int level = 0;
	static public int LifeLevel = 0;
	static public float time = 1.0f;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void FixedUpdate () {

		if (personagem.sleep == false) {

			contador = contador + 0.1f;

			// contador print(Mathf.Round(contador));
			time = Time.timeScale;

			if (personagem.PowerSpecial == false) {


				if (contador >= 50 && contador <= 250) {
					level = 1;
					Time.timeScale = 1.2f;



				}if(contador >= 251 && contador <= 500){
					level = 2;
					Time.timeScale = 1.3f;



				}if(contador >= 501 && contador <= 900){
					level = 3;
					Time.timeScale = 1.5f;



				}if(contador >= 901 && contador <= 1200){
					level = 4;


				}
				
			}

		
		}

			
	}
}

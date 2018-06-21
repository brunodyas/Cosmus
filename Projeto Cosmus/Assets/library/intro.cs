using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour {

	public SpriteRenderer logo;

	float alpha = 0f;
	bool start = true;
	float time = 0f;


	// Use this for initialization
	void Start () {
		
		GetComponents<SpriteRenderer> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (start == true) {
			alpha += 0.005f;
			time += Time.deltaTime;
		
		}else
			alpha -= 0.005f;
			time += Time.deltaTime;

		if (time >= 10 && start == true) {
			start = false;
			time = 0f;
		}

		if (time >= 5 && start == false) {
			SceneManager.LoadScene ("idioma");
		}		

		logo.color = new Color (1.0f, 1.0f, 1.0f, alpha);
		
	}
}

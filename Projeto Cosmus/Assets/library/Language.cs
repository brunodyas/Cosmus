using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Language : MonoBehaviour {

	static public TextAsset TextFile;


	// Use this for initialization
	void Start () {
	
	}


	void OnMouseDown(){
	
		if (gameObject.name == "pt") {

			TextFile = Resources.Load("pt") as TextAsset;
			SceneManager.LoadScene ("inicio");


		}
	
		if (gameObject.name == "en") {

			TextFile = Resources.Load("en") as TextAsset;
			SceneManager.LoadScene ("inicio");

		}

		if (gameObject.name == "sp") {

			TextFile = Resources.Load("sp") as TextAsset;
			SceneManager.LoadScene ("inicio");
		
		}


	}

	
	// Update is called once per frame
	void Update () {
		
	}
}

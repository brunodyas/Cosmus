using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paused : MonoBehaviour {

	public bool pause;

	// Use this for initialization
	void Start () {

		pause = false;
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}

	public void Paused (){

		if (pause== false) {		

			Time.timeScale = 0f;
			pause = true;


		} else if (pause==true){

			Time.timeScale = 1.0f;
			pause = false;
		}
	
	}
}

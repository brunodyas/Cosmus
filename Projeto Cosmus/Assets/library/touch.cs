using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class touch : MonoBehaviour {

	//public static bool simulateMouseWithTouches;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began || Input.GetButton ("Fire1"))
		{
			SceneManager.LoadScene ("cutscene01");
		}
			
		}
			
		
		}

	

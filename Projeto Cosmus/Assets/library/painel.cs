using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class painel : MonoBehaviour {



	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (cutscene.ato == 1) {
		
			while (GetComponent<Transform> ().localScale.x <= 1f) {
			
				GetComponent<Transform> ().localScale += new Vector3 (Time.deltaTime /100 , 0, 0);


							
			
			}
		
		}
		
	}
}

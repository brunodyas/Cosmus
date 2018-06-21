using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 

public class interf : MonoBehaviour {

	Text valor_uniqueis;

	// Use this for initialization
	void Start () {

		valor_uniqueis = GetComponent<Text>();

	}

	// Update is called once per frame
	void FixedUpdate () {

		valor_uniqueis.text = Unikeis.uniqueis_pacial.ToString();
		
 	}

}




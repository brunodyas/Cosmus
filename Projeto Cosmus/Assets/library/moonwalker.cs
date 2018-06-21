using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moonwalker : MonoBehaviour {



	// Use this for initialization
	void Start () {

		SoundManager.Instance.EfxBoss ();

	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.x <= 5.5) {
		
			GetComponent<bullet> ().speed = 0;
			GetComponent<Animator>().SetBool("in",false);

		}
		
	}
}

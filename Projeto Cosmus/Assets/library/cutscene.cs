using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cutscene : MonoBehaviour {

	static public int ato = 0;
	public float ato01;
	public float ato02;
	public float ato03;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.y >= ato01 && ato == 0) {

			GetComponent<Rigidbody2D> ().simulated = false;
			ato = 1;
		
		}

		if (transform.position.y >= ato02 && ato == 1) {

			GetComponent<Rigidbody2D> ().simulated = false;
			ato = 2;

		}

		if (transform.position.y >= ato03 && ato == 2) {

			GetComponent<Rigidbody2D> ().simulated = false;
			ato = 3;

		}

		if (Input.GetMouseButton (0) || Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) {

			if (ato == 1 && GetComponent<Rigidbody2D> ().simulated == false) {
				GetComponent<Rigidbody2D> ().simulated = true;

			}

			if (ato == 2 && GetComponent<Rigidbody2D> ().simulated == false) {
				GetComponent<Rigidbody2D> ().simulated = true;
			}

			if (ato == 3 && GetComponent<Rigidbody2D> ().simulated == false) {
				SceneManager.LoadScene ("stage1");
			}

		}
		
	}
}

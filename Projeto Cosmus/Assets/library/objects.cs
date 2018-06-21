using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objects : MonoBehaviour {

	public GameObject[] newobjects;
	public GameObject[] newobjectsn1;
	public GameObject[] newobjectsn2;
	public GameObject[] newobjectsn3;
	public GameObject[] newobjectsn4;
	public GameObject filetes;
	public GameObject Boss;
	bool BossOn = false;
	public GameObject[] power;
	private int instobjects;
	float contador = 35f;
	float fileteTime;
	float PowerTime;


	// Use this for initialization
	void Start () {
		
					
	}

	// Update is called once per frame
	void FixedUpdate () {

		if (personagem.sleep == false) {
			contador = contador + Random.Range (0.01f, 0.1f);

			fileteTime += Time.deltaTime;

			if (fileteTime >= 10 && syslevel.LifeLevel>=1) {

				Instantiate (filetes , new Vector2 (16.25f, Random.Range (-2.3f, 4f)), transform.rotation);

				fileteTime = 0;

			}

			PowerTime += Time.deltaTime;

			if (PowerTime >= 20) {

				instobjects = Random.Range (0, power.Length);

				Instantiate (power [instobjects] , new Vector2 (16.25f, Random.Range (-2.3f, 4f)), transform.rotation);

				PowerTime = 0;

			}
		


			if (contador>=10 && syslevel.level == 0) {

				instobjects = Random.Range (0, newobjects.Length);

				Instantiate (newobjects [instobjects], transform.position, transform.rotation);

				contador = 0f;
			}


			if (syslevel.level == 1 && contador >= 10) {

				instobjects = Random.Range (0, newobjectsn1.Length);

				Instantiate (newobjectsn1 [instobjects], transform.position, transform.rotation);

				contador = 0f;
			}

			if (syslevel.level == 2 && contador >= 10) {

				instobjects = Random.Range (0, newobjectsn2.Length);

				Instantiate (newobjectsn2 [instobjects], transform.position, transform.rotation);

				contador = 0f;
			}	

			if (syslevel.level == 3 && contador >= 10) {

				instobjects = Random.Range (0, newobjectsn3.Length);

				Instantiate (newobjectsn3 [instobjects], transform.position, transform.rotation);

				contador = 0f;
			}

			if (syslevel.level == 4 && contador >= 10) {

				instobjects = Random.Range (0, newobjectsn4.Length);

				Instantiate (newobjectsn4 [instobjects], transform.position, transform.rotation);

				contador = 0f;

				if (BossOn == false) {
				

					Instantiate (Boss, new Vector3(80f,-0.2f,0f), transform.rotation);
					BossOn = true;
				
				}
			}		


		}
	}
}


		



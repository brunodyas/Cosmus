using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	public class bullet : MonoBehaviour {

	public float speed = -4;
	public bool AutoDestroy = true;
	//public personagem variavel;

	// Use this for initialization
	void Start () {
		

	}

	// Update is called once per frame
	void FixedUpdate () {

		if ( personagem.sleep == false) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, 0);
		}else
			GetComponent<Rigidbody2D> ().velocity = new Vector2 ( 0, 0);

		if(gameObject.transform.position.x <= -20 || gameObject.transform.position.y <= -10 & AutoDestroy == true ) {

			Destroy (gameObject);
		}

				
			
		
	}
}



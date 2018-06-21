using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personagem : MonoBehaviour {

    Animator animador;
	float force = 5.5f;
	Rigidbody2D fisica;
	public static float energia;
	public SpriteRenderer barra;
	bool colidiu = false;
	public static bool sleep = false;
	BoxCollider2D coll;
	public static bool abi = false;
	float ContAbi = 0f;
	float atirando = 2f;
	public GameObject power;
	public GameObject shield;
	public GameObject special;
	public static Vector2 pos;
	static public bool PowerSpecial = false;
	float SpecialTime;


    // Use this for initialization
    void Start () {
		coll = GetComponent<BoxCollider2D> ();
		animador = GetComponent<Animator>();
		fisica = GetComponent<Rigidbody2D> ();

        animador.SetBool("noChao",false);
        animador.SetBool("atirando",false);
        animador.SetBool("escudo", false);
        animador.SetBool("derrotado",false);


		if (loja.BarLife == 1) {
		
			energia = 25f;
		}if (loja.BarLife == 2) {

			energia = 50f;

		}if (loja.BarLife == 3) {

			energia = 75f;
		
		}if (loja.BarLife == 4) {

			energia = 100f;

		}

    }

    // Update is called once per frame

	void FixedUpdate () {

		pos = new Vector2 (gameObject.transform.position.x, gameObject.transform.position.y);

		barra.size = new Vector2 ( energia / 16.5f , barra.size.y);
	

		if (abi == true) {
			ContAbi += Time.deltaTime;;
			animador.SetBool ("atirando", true);
			Atirando ();

			if (ContAbi >= 10f) {

				animador.SetBool("atirando",false);
				ContAbi = 0f;
				abi = false;
		} 


		}

		if (PowerSpecial == true) {
			ContAbi += Time.deltaTime;
			fisica.simulated = false;
			Time.timeScale = 5.0f;

			if (ContAbi >= 8) {
				Time.timeScale = SpecialTime;
				ContAbi = 0f;
				fisica.simulated = true;
				PowerSpecial = false;
			}

		}		
			
			




		if (Input.GetMouseButton (0) || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {

			if (sleep == false) {
				fisica.velocity = new Vector2 (0,force);
				animador.SetBool ("noChao", false);

			
			}
					
		}

		if (colidiu == true) {
			if (energia <= 0){
				SoundManager.Trilha.Stop();
				SoundManager.Instance.EfxGameover ();
				sleep = true;
				animador.SetBool ("sleep", true);
				fisica.velocity = new Vector2 (0,8f);
				coll.isTrigger = true;
				colidiu = false;
			}else
				animador.SetBool("hit", false);
				colidiu = false;

		}

   }

	void OnTriggerEnter2D (Collider2D cosmus){

		if (cosmus.gameObject.tag == "shot") {


			if (energia > 0) {

				energia -= 25f;
				animador.SetBool("hit", true);
				colidiu = true;
			}

		}

		if (cosmus.gameObject.tag == "filetes") {

			if (loja.BarLife == 2 && energia <=49) {

				energia += 25f;
			}if (loja.BarLife == 3 && energia <=74) {

				energia += 25f;

			}if (loja.BarLife == 4 && energia <=99) {

				energia += 25f;

			}

		}

		if (cosmus.gameObject.tag == "hab") {

			abi = true;


		}
		if (cosmus.gameObject.tag == "shield") {

			Instantiate (shield, new Vector2 (gameObject.transform.position.x , gameObject.transform.position.y), transform.rotation);


		}


		if (cosmus.gameObject.tag == "special") {

			Instantiate (special, new Vector2 (gameObject.transform.position.x , gameObject.transform.position.y), transform.rotation);
			SpecialTime = Time.timeScale;
			PowerSpecial = true;


		}

	}

	void OnCollisionEnter2D (Collision2D col){

		if (col.gameObject.tag == "drone") {


			if (energia > 0) {

				energia -= 25f;
				animador.SetBool("hit", true);
				colidiu = true;
			}

		}

		if (col.gameObject.tag == "plaform") {

			animador.SetBool ("noChao", true);

		
		}	

		if (col.gameObject.tag == "pedra") {
			

			if (energia > 0) {
			
				energia -= 25f;
				animador.SetBool("hit", true);
				colidiu = true;
			}

		}

		if (col.gameObject.tag == "limite") {

				energia = 0f;
				animador.SetBool("hit", true);
				colidiu = true;

		
		}

	}

	void Atirando (){
	  atirando += 0.1f;

		if (atirando >= 3.0f && sleep== false) {
			Instantiate (power, new Vector2 (gameObject.transform.position.x + 0.9f, gameObject.transform.position.y - 0.2f), transform.rotation);
			SoundManager.Instance.EfxShotCosmus ();
			atirando = 0f;
		}
		
	}


}

      

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {


	public static SoundManager Instance = null;
	public AudioClip UniqueisEfx;
	public AudioClip ShotCosmusEfx;
	public AudioClip ExplosionEfx;
	public AudioClip CollMiniBangEfx;
	public AudioClip GameoverEfx;
	public AudioClip Moonwalker;
	public static AudioSource Trilha;
	public  AudioSource EfxSound;

	void Start(){
	
		Trilha = GetComponent<AudioSource> ();
	
	
	}


	void Awake () {

		if (Instance == null) {
		
			Instance = this;
		
		} else if (Instance != this) {

			Destroy (Instance);
		
		}


	}


	public void PlaySingle(AudioClip clip){
	
		EfxSound.clip = clip;
		EfxSound.Play();
	
	}

	public void PlayTrilha(AudioClip clip){

		Trilha.clip = clip;
		Trilha.Play();

	}



	public void EfxUniqueis(){
	 
		PlaySingle (UniqueisEfx);
	}

	public void EfxBoss(){

		PlayTrilha (Moonwalker);
	}

	public void EfxShotCosmus(){

		PlaySingle (ShotCosmusEfx);
	}

	public void EfxExplosion(){

		PlaySingle (ExplosionEfx);
	}

	public void EfxCollMiniBang(){

		PlaySingle (CollMiniBangEfx);
	}

	public void EfxGameover(){

		PlaySingle (GameoverEfx);
	}


}


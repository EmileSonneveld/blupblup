using UnityEngine;
using System.Collections;

public class GestionSound : MonoBehaviour {

	public static GestionSound instance;

	public AudioSource audioSource;
	public AudioClip jumpClip;
	public AudioClip hitClip;
	public AudioClip destroyCoral;
	public AudioClip plantPlante;
	public AudioClip plantharvest;

	public AudioSource Walk;
	public AudioClip[] StepClip;

	[HideInInspector]
	public bool walksound;


	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		if (walksound) {
			if(!Walk.isPlaying){
				Walk.clip=StepClip[Random.Range(0,StepClip.Length-1)];
				Walk.Play();
			}
		}
	}

	public void soundJump(){
		audioSource.PlayOneShot(jumpClip);
	}

	public void soundHit(){
		//if (!Hammer_Hit.isPlaying)
		audioSource.PlayOneShot(hitClip);
	}

	public void soundDestroyCoral(){
		audioSource.PlayOneShot (destroyCoral);
	}

	public void soundplantPlante(){
		audioSource.PlayOneShot(plantPlante);
	}

	public void soundplantHarvest(){
		audioSource.PlayOneShot(plantharvest);
	}
}

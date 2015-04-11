using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class WaterPower : MonoBehaviour {
	public Vortex[] vortex_ref;
	private CharacterController playerCharControler;
	float specialTime = 0;

	// Use this for initialization
	void Start () {
		playerCharControler = GameObject.Find ("player").GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void Update () {
		specialTime += Time.deltaTime + playerCharControler.velocity.magnitude/800f;
		for(int i=0;i<vortex_ref.Length;i++){
			vortex_ref[i].angle = 10*Mathf.Sin(specialTime*(1+0.2f*i)+i);
		}
	}
}

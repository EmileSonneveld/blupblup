using UnityEngine;
using System.Collections;

public class lerpcamera : MonoBehaviour {


	public Transform tete;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.rotation= Quaternion.Lerp(this.transform.rotation,tete.rotation,0.4f);
	}
}

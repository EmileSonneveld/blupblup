using UnityEngine;
using System.Collections;

public class Destroys : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Destroybuilding(){
		Rigidbody[] listrigid = GetComponentsInChildren<Rigidbody>();
		foreach(Rigidbody kikou in listrigid){
			kikou.isKinematic=false;

		}

		Rigidbody hello = GetComponent<Rigidbody>();
		if(hello)
			hello.isKinematic=false;
		  
	}
}

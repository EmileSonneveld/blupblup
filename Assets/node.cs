using UnityEngine;
using System.Collections;

public class node : MonoBehaviour {

	public int nbrmaxplant;
	public int maxO2;
	public int minO2;
	private bool isplant=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public bool canplant(){
		return (nbrmaxplant>0 && !isplant);
	}

	public void plant(){
		nbrmaxplant--;
		isplant=true;
	}

	public int getO2(){
		isplant=false;
		return Random.Range(minO2,maxO2);
	}

}

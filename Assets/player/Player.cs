using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


	public CharacterController characterController;
	private float viewDirCam=0;
	private float viewDirPlayer=0;
	public float mouseMultiply = 4;
	public float movementMultiply = 9;
	public Camera camera;

	// Use this for initialization
	void Start () {
		this.camera = Camera.main;
		characterController=GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
		viewDirCam +=  -Input.GetAxis("Mouse Y") * mouseMultiply;
		camera.transform.localRotation = Quaternion.Euler(new Vector3(viewDirCam,0,0));

		viewDirPlayer +=  Input.GetAxis("Mouse X") * mouseMultiply;
		this.transform.rotation = Quaternion.Euler(new Vector3(0,viewDirPlayer,0));



		if ( Input.GetAxis("Jump") > 0.001f){
			direction += new Vector3(0, 100, 0);
		}
		characterController.Move(this.transform.rotation*direction * Time.deltaTime * movementMultiply);
		
	}


}

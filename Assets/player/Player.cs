using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	CharacterController characterController;
	private float viewDirCam=0;
	private float viewDirPlayer=0;
	public float mouseMultiply = 4;
	public float movementMultiply = 9;
	public Camera camera_ref;
	bool isPlanting = false;
	float plantingProgress = 0;
	public int isInPlantingZone = 0;
	private GameObject oxyGo;
	float oxygenLevel = 100;
	Vector3 initialOxyPos;
	public float jump_fact = 0.35f;
	public float gravity = 1;

	float y_speed = .0f;


	public GameObject plant;

	// Use this for initialization
	void Start () {
		oxyGo = transform.FindChild("CameraUi/oxygen").gameObject;
		initialOxyPos = oxyGo.transform.localPosition;

		this.camera_ref = Camera.main;
		characterController=GetComponent<CharacterController>();
	}

	void OnTriggerEnter(Collider collider){
		if(collider.gameObject.CompareTag("node")){
			isInPlantingZone++;
		}else if(collider.gameObject.CompareTag("plant")){
			var plant = collider.GetComponent<plant>();
			plant.Die();
			oxygenLevel += plant.GetOxygenLevel();
		}
	}
	
	void OnTriggerExit(Collider collider){
		if(collider.gameObject.CompareTag("node")){
			isInPlantingZone=Mathf.Max(isInPlantingZone-1,0);
		}
	}

	// Update is called once per frame
	void Update () {
		if ( oxygenLevel > 0 )
		{
			oxygenLevel -= Time.deltaTime * 5;
			float w = oxygenLevel / 100;
			oxyGo.transform.localScale = new Vector3(
				oxyGo.transform.localScale.x, 
				w,
				oxyGo.transform.localScale.z
			);
			Vector3 tmp = initialOxyPos;
			tmp.y = initialOxyPos.y + w;
			oxyGo.transform.localPosition = tmp;
		}else{
			oxygenLevel = 0;
		}

		Vector3 direction = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
		viewDirCam +=  -Input.GetAxis("Mouse Y") * mouseMultiply;
		camera_ref.transform.localRotation = Quaternion.Euler(new Vector3(viewDirCam,0,0));

		viewDirPlayer +=  Input.GetAxis("Mouse X") * mouseMultiply;
		this.transform.rotation = Quaternion.Euler(new Vector3(0,viewDirPlayer,0));

		if ( Input.GetAxis("Jump") > 0.001f && characterController.isGrounded){
			y_speed = jump_fact*gravity;
		}else{
			direction.y = y_speed; //(characterController.velocity.y - 9.81f)*Time.deltaTime;
			if( !characterController.isGrounded){
				y_speed -= gravity  *Time.deltaTime;
			}else{
				y_speed=0;
			}
		}
		//Debug.Log(characterController.velocity.y);

		if(isPlanting)
			direction*=0;
		//direction.y = characterController.velocity.y;
		characterController.Move(this.transform.rotation*direction * Time.deltaTime * movementMultiply);


		if ( Input.GetAxis("Fire1")>0.001f && !isPlanting && isInPlantingZone > 0 ){
			isPlanting = true;
			plantingProgress = 0;
			Debug.Log ("planting in progress...");
		}

		if( isPlanting ){
			plantingProgress += Time.deltaTime;
			if ( plantingProgress > 5 ){
				isPlanting = false;
				Instantiate(plant, this.transform.position + this.transform.forward * 2 + Vector3.down*1.75f, plant.transform.rotation);
			}
		}
		
	}


}

using UnityEngine;
using System.Collections;

enum State
{
	menu,
	falling,
	playing,
	dead
};

public class Player : MonoBehaviour {

	private State playerState = State.menu;

	CharacterController characterController;
	private float viewDirCam=89;
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
	private bool attaque=false;
	private node noderef;

	float y_speed = .0f;

	ParticleSystem psBulles;
	Camera menuCam;


	public GameObject plant;

	// Use this for initialization
	void Start () {
		psBulles = GameObject.Find("menuSystem").GetComponent<ParticleSystem>();
		menuCam = GameObject.Find("menuCamera").GetComponent<Camera>();
		oxyGo = transform.FindChild("CameraUi/oxygen").gameObject;
		initialOxyPos = oxyGo.transform.localPosition;

		this.camera_ref = Camera.main;
		characterController=GetComponent<CharacterController>();
	}

	//penis

	void OnTriggerEnter(Collider collider){
		if(collider.gameObject.CompareTag("node")){
			isInPlantingZone++;
			noderef=collider.gameObject.GetComponent<node>();
		}else if(collider.gameObject.CompareTag("plant")){
			var plant = collider.GetComponent<plant>();
			plant.Die();
			oxygenLevel += plant.GetOxygenLevel();
			GestionSound.instance.soundplantHarvest();
		}
	}
	
	void OnTriggerExit(Collider collider){
		if(collider.gameObject.CompareTag("node")){
			isInPlantingZone=Mathf.Max(isInPlantingZone-1,0);
		}
	}


	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Backspace)) {
			if (Cursor.lockState == CursorLockMode.None) {
				Cursor.lockState = CursorLockMode.Locked;
			} else {
				Cursor.lockState = CursorLockMode.None;
			}
		}


		viewDirCam +=  -Input.GetAxis("Mouse Y") * mouseMultiply;
		camera_ref.transform.localRotation = Quaternion.Euler(new Vector3(viewDirCam,0,0));
		
		viewDirPlayer +=  Input.GetAxis("Mouse X") * mouseMultiply;
		this.transform.rotation = Quaternion.Euler(new Vector3(0,viewDirPlayer,0));




		switch( playerState ){

		case State.menu:
			if( Input.GetKeyDown(KeyCode.Space)){
				playerState = State.falling;
			}
			//RenderSettings.fogColor = new Color(90, 90, 165);
			RenderSettings.fogDensity = 0.2f;
			break;

		case State.falling:
			menuCam.enabled = false;
			psBulles.Pause();
			y_speed = -3;
			playBehaviour();
			//RenderSettings.fogColor = Color.Lerp( RenderSettings.fogColor, Color.blue, 0.1f);
			RenderSettings.fogDensity += (0.02f - RenderSettings.fogDensity)*0.02f;

			if( characterController.isGrounded ){
				playerState = State.playing;
			}

			break;

		case State.playing:
			playBehaviour();
			break;

		case State.dead:
			break;
		}

		
	}


	void playBehaviour(){
		if ( oxygenLevel > 0 )
		{
			oxygenLevel -= Time.deltaTime * 2;
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

		if (direction.magnitude > 0.1f)
			GestionSound.instance.walksound = true;
		else
			GestionSound.instance.walksound = false;

		if ( Input.GetAxis("Jump") > 0.001f && characterController.isGrounded){
			y_speed = jump_fact*gravity;
			GestionSound.instance.soundJump();
		}else{
			direction.y = y_speed; 
			if( !characterController.isGrounded){
				y_speed -= gravity  *Time.deltaTime;
			}else{
				y_speed=0;
			}
		}
		
		if(isPlanting)
			direction*=0;
		characterController.Move(this.transform.rotation*direction * Time.deltaTime * movementMultiply);
		
		
		if ( Input.GetAxis("Fire1")>0.001f && !isPlanting && isInPlantingZone > 0 && noderef.canplant()){
			isPlanting = true;
			plantingProgress = 0;
			Debug.Log ("planting in progress...");
		}
		
		if( isPlanting ){
			plantingProgress += Time.deltaTime;
			if ( plantingProgress > 2 ){
				GestionSound.instance.soundplantPlante();
				noderef.plant();
				isPlanting = false;
				GameObject temp = (GameObject) Instantiate(plant, this.transform.position + this.transform.forward * 2 + Vector3.down*1.75f, plant.transform.rotation);
				temp.GetComponent<plant>().noderef=noderef;
			}
		}
		
		if( Input.GetAxis("Fire1") > 0.01f && !attaque){
			tryattack();
			attaque=true;
		}else if (Input.GetAxis("Fire1") < 0.001f){
			attaque=false;
		}

	}

	void tryattack(){
		Vector3 fwd = camera_ref.transform.TransformDirection(Vector3.forward);
		RaycastHit hitInfo;
		if (Physics.Raycast(transform.position, fwd,out hitInfo, 1,1<<9)){
			hitInfo.collider.gameObject.GetComponent<Corail>().applydomage(5);
			GestionSound.instance.soundHit();
		}
	}


}

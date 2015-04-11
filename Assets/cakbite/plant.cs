using UnityEngine;
using System.Collections;

public class plant : MonoBehaviour {

	int growingState = 0;
	float growTimer = 0;
	bool isVisible = false;
	GameObject player;
	public float minGrowDistance = 20;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("player");
	
	}
	
	void OnBecameVisible()
	{
		isVisible = true;
	}
	void OnBecameInvisible()
	{
		isVisible = false;
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 distanceToCam = this.transform.position - player.transform.position;
		if (!isVisible || distanceToCam.magnitude > minGrowDistance){

			if( growTimer>3 && growingState < 3 ){
				growingState++;
				growTimer = 0;

				this.transform.position += new Vector3(0, 0.6f, 0);

			}
			else
			{
				growTimer += Time.deltaTime;
			}
		}

	}

}

using UnityEngine;
using System.Collections;

public class Corail : MonoBehaviour {

	private float offsetcolor;
	private float frenquencecolor;
	private float pv=100;
	private Material material;
	// Use this for initialization
	void Start () {
		offsetcolor = Random.Range(0,255);
		frenquencecolor = Random.Range(30,50);
		material=GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
		float h,s,v;
		h=(Time.time*frenquencecolor+offsetcolor)%360;
		s=224f/255f;
		v=(35f+2*pv)/255f;

		Color temp = ColorFromHSV(h,s,v);
		material.color=temp;

	}

	public void applydomage(int damage){
		pv-=damage;
		if(pv<0){
			Destroy(gameObject);
		}
	}

	public static Color ColorFromHSV(float h, float s, float v, float a = 1)
	{
		// no saturation, we can return the value across the board (grayscale)
		if (s == 0)
			return new Color(v, v, v, a);
		
		// which chunk of the rainbow are we in?
		float sector = h / 60;
		
		// split across the decimal (ie 3.87 into 3 and 0.87)
		int i = (int)sector;
		float f = sector - i;
		
		float p = v * (1 - s);
		float q = v * (1 - s * f);
		float t = v * (1 - s * (1 - f));
		
		// build our rgb color
		Color color = new Color(0, 0, 0, a);
		
		switch(i)
		{
		case 0:
			color.r = v;
			color.g = t;
			color.b = p;
			break;
			
		case 1:
			color.r = q;
			color.g = v;
			color.b = p;
			break;
			
		case 2:
			color.r  = p;
			color.g  = v;
			color.b  = t;
			break;
			
		case 3:
			color.r  = p;
			color.g  = q;
			color.b  = v;
			break;
			
		case 4:
			color.r  = t;
			color.g  = p;
			color.b  = v;
			break;
			
		default:
			color.r  = v;
			color.g  = p;
			color.b  = q;
			break;
		}
		
		return color;
	}

}

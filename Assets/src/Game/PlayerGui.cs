using UnityEngine;
using System.Collections;

public class PlayerGui : MonoBehaviour {

	public Texture2D crosshair;
	public float crosshairSize = 4.0f;
	float crosshairPosAdjust;
	

	// Use this for initialization
	void Start () {
		crosshairPosAdjust = crosshairSize/2;
	}
	
	// Update is called once per frame
	void OnGUI () {
		GUI.DrawTexture(new Rect(Screen.width/2-crosshair.width/crosshairSize,
		 		                 Screen.height/2-crosshair.height/crosshairSize,
		 		                 crosshair.width/crosshairPosAdjust, crosshair.height/crosshairPosAdjust),
		 		        crosshair);
		 		        
	}
}

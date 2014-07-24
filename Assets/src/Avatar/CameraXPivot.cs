using UnityEngine;
using System.Collections;

public class CameraXPivot : MonoBehaviour {

	float lookSensitivity = -5.0f;

	void Start(){
		Transform cam = transform.Find("Main Camera");
		//cam.camera.enabled = false;
		//this.enabled = false;
	}

	void Update () {
		float mouseY = Input.GetAxis("Mouse Y");
		Vector3 rotation = transform.localEulerAngles;
		rotation.x += mouseY * lookSensitivity;
		transform.localEulerAngles = rotation;
	}
}

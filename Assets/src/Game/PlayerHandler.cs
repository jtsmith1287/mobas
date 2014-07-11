using UnityEngine;
using System.Collections;

public class PlayerHandler : MonoBehaviour {

	GameObject player;
	Vector3 spawnPoint;

	// Use this for initialization
	void Start () {
		spawnPoint = GameObject.Find("SpawnPoint").transform.position;
		player = PhotonNetwork.Instantiate ("Player",
		                                    spawnPoint, 
		                                    Quaternion.identity,
		                                    0);
		//CameraXPivot cam_script = player.GetComponent<CameraXPivot>();
		//Transform cam = cam_script.transform.Find("Main Camera");
		//cam.camera.enabled = true;
		//AvatarMovement movement = player.GetComponent<AvatarMovement>();
		//movement.enabled = true;
		//cam_script.enabled = true;
	}

	void EnableCharacterControl(){
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

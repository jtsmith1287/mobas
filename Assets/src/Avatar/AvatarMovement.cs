using UnityEngine;
using System.Collections;

public class AvatarMovement : MonoBehaviour {

	CharacterController controller;
	[SerializeField]
	float movementSpeed = 10.0f;
	[SerializeField]
	float lookSensitivity = 5.0f;
	
	float gravity;
	float lookx;

	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	void move(){
		float time = Time.deltaTime;
		if (controller.isGrounded) {
			gravity = 0.0f;
		} else {
			gravity -= 9.81f * time;
		}
		
		float moveX = Input.GetAxis("Horizontal") * movementSpeed * time;
		float moveY = Input.GetAxis("Vertical") * movementSpeed * time;
		// Diagonal movement compensation
		// FIX THIS HORRID PUUUUUUUUUKE
		if (moveX != 0.0f && moveY != 0.0f){
			float diagonal_move = Mathf.Sqrt(moveX * moveX + moveY * moveY);
			if (moveX < 0.0f){
				moveX = diagonal_move / -2;
			} else {
				moveX = diagonal_move / 2;
			}
			if (moveY < 0.0f){
				moveY = diagonal_move / -2;
			} else {
				moveY = diagonal_move / 2;
			}
			
			
		}
		Vector3 direction = new Vector3 (moveX, gravity, moveY);
		
		controller.Move(transform.TransformDirection(direction));
	}
	
	void lookLeftRight(){
		float mouseX = Input.GetAxis("Mouse X");
		Vector3 rotation = transform.localEulerAngles;
		rotation.y += mouseX * lookSensitivity;
		transform.localEulerAngles = rotation;
	}
	
	void Update () {
		move();
		lookLeftRight();
	}
}

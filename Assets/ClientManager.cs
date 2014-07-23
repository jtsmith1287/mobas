using UnityEngine;
using System.Collections;

public class ClientManager : MonoBehaviour {

	RoomOptions newRoomDetails;
	
	
	void setRoomOptions(){
		byte max = 10;
		newRoomDetails = new RoomOptions ();
	}
	
	void JoinRoom(){
		PhotonNetwork.JoinOrCreateRoom("Yeeha!",
		                               newRoomDetails,
		                               TypedLobby.Default);
	}

	// Use this for initialization
	void Start () {
		setRoomOptions();
		JoinRoom();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

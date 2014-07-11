using UnityEngine;
using System.Collections;

public class LoadingScreen : MonoBehaviour {

	[SerializeField]
	Texture2D _bg;
	
	[SerializeField]
	Texture2D _text;

	RoomOptions newRoomDetails;

	void setRoomOptions(){
		byte max = 10;
		newRoomDetails = new RoomOptions ();
	}

	void Start(){
		setRoomOptions ();
		JoinRoom ();
	}

	void JoinRoom(){
		PhotonNetwork.JoinOrCreateRoom("Yeeha!",
		                               newRoomDetails,
		                               TypedLobby.Default);
	}

	void OnJoinedRoom(){
		Application.LoadLevel ("main");
	}

	void OnGUI(){
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), _bg);
		GUI.Label(new Rect(Screen.width/2, Screen.height/2, 200, 200),
		          PhotonNetwork.connectionStateDetailed.ToString ());
	}
}

using UnityEngine;
using System.Collections;

public class InitialConnect : MonoBehaviour {

	static bool connected = false;

	// Use this for initialization
	void Start () {
		//PhotonNetwork.logLevel = PhotonLogLevel.Full;
		PhotonNetwork.ConnectToMaster("192.168.1.7", 5055, "cfdf390f-742d-4fe3-8ff5-fecff18f7607", "0.1");
	}
	void OnJoinedLobby(){
		connected = true;
		Debug.Log("Called: OnJoinedLobby");
	}
	/* Use this method to start the realtime map processes.
	* If this method gets called then the player is logged
	* in and ready to start querying the server for info */
	
}
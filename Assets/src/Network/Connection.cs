using UnityEngine;
using System.Collections;

public class Connection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//PhotonNetwork.logLevel = PhotonLogLevel.Full;
		PhotonNetwork.ConnectUsingSettings ("0.1");
	}
	void OnJoinedLobby(){}
	/* Use this method to start the realtime map processes.
	* If this method gets called then the player is logged
	* in and ready to start querying the server for info */
	
}
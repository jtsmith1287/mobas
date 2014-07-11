using UnityEngine;
using System.Collections;

public class Connection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		PhotonNetwork.logLevel = PhotonLogLevel.Full;
		PhotonNetwork.ConnectUsingSettings ("0.1");
	}
	void OnJoinedLobby(){}
}
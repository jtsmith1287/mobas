using UnityEngine;
using System.Collections;

public class MainMenuGui : MonoBehaviour {

	[SerializeField]
	Texture2D _mainMenuBG;
	[SerializeField]
	Texture2D _startGameButton;
	[SerializeField]
	Texture2D _quitButton;
	
	Rect _buttonLayoutRect = new Rect(200, 200, 500, 500);

	void Start(){
	}

	void OnGUI(){
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), _mainMenuBG);
		
		GUILayout.BeginArea(_buttonLayoutRect);
		
		if (GUILayout.Button(_startGameButton)){
			Application.LoadLevel("loadingScreen");	
		}
		if (GUILayout.Button(_quitButton)){
			Application.Quit();
		}
		GUILayout.EndArea();
	}
}

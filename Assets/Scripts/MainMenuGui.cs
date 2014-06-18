using UnityEngine;
using System.Collections;

public class MainMenuGui : MonoBehaviour {

	[SerializeField]
	Texture2D _mainMenuBG;
	[SerializeField]
	Texture2D _startGameButton;

	void OnGUI(){
		GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), _mainMenuBG);
		
		if (GUI.Button(new Rect(Screen.width/2 -_startGameButton.width/2,
							Screen.height/2 - _startGameButton.height/2,
							256, 64), _startGameButton)) {
			Application.LoadLevel("main");
		}
	}
}

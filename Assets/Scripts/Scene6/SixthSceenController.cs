using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SixthSceenController : SceneController {
	public Text textResult;

	// Use this for initialization
	void Start () {
		string characterName = "";

		if (GameController.instance.getWinnerNumber () == 1) {
			characterName = GameController.instance.getPlayer1 ().getCharacter ().getName ();
		} else if (GameController.instance.getWinnerNumber () == 2) {
			characterName = GameController.instance.getPlayer2 ().getCharacter ().getName ();
		} else {
			Debug.Log ("This game only allows two players.");
		}
		textResult.text = characterName + "取得了胜利";
	}

}

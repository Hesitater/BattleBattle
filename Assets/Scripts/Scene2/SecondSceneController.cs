using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecondSceneController : SceneController {
	public Transform[] dicePrefab;
	public Text hpText;
	public Text spText;
	public Button buttonTriggerSkill;

	// Use this for initialization
	void Start () {
		Player player1 = GameController.instance.getPlayer1 ();
		// Untrigger skill
		player1.untriggerSkill ();
		// Display dice
		int dicePoint = player1.rollDice ();
		Instantiate (dicePrefab[dicePoint - 1]);
		// Display HP
		hpText.text = "血量：" + player1.hp.ToString ();
		// Display SP
		spText.text = "技能点：" + player1.sp.ToString ();
		// Disable skill button if sp is zero
		if (player1.sp == 0) {
			buttonTriggerSkill.enabled = false;
			buttonTriggerSkill.image.color = Color.black;
		}
	}
}

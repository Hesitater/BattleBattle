using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FourthSceneController : SceneController {
	public Transform[] dicePrefab;
	public Text hpText;
	public Text spText;
	public Button buttonTriggerSkill;

	// Use this for initialization
	void Start () {
		Player player2 = GameController.instance.getPlayer2 ();
		// Untrigger skill
		player2.untriggerSkill ();
		// Display dice
		int dicePoint = player2.rollDice ();
		Instantiate (dicePrefab[dicePoint - 1]);
		// Display HP
		hpText.text = "血量：" + player2.hp.ToString ();
		// Display SP
		spText.text = "技能点：" + player2.sp.ToString ();
		if (player2.sp == 0) {
			buttonTriggerSkill.enabled = false;
			buttonTriggerSkill.image.color = Color.black;
		}
	}
}

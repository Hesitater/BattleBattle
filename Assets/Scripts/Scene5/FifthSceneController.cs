using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FifthSceneController : MonoBehaviour {
	public Text textPlayer1;
	public Text textPlayer2;
	public Transform[] dices;
	public Text textHP1;
	public Text textHP2;

	private bool switchDice;

	// Use this for initialization
	void Start () {
		GameController gameController = GameController.instance;
		Player player1 = gameController.getPlayer1 ();
		Player player2 = gameController.getPlayer2 ();

		// Set character text
		textPlayer1.text = player1.getCharacter ().getName ();
		textPlayer2.text = player2.getCharacter ().getName ();
		// Handle skill effects
		this.switchDice = false;
		settleSkill (player1);
		settleSkill (player2);
		// Set dices for skill effects
		if (this.switchDice) {
			int tempPoint = player1.getDicePoint ();
			player1.setDicePoint (player2.getDicePoint ());
			player2.setDicePoint (tempPoint);
		}
		int dice1 = player1.getDicePoint ();
		int dice2 = player2.getDicePoint ();
		// Display dices
		Instantiate (dices [dice1 - 1], new Vector3 (-3.4f, 0.8f), Quaternion.identity);
		Instantiate (dices [dice2 - 1], new Vector3 (3.4f, 0.8f), Quaternion.identity);
		// Display HPs
		int diceDifference = dice1 - dice2;
		if (diceDifference > 0) { // Player 1 wins
			textHP1.text = "血量：" + player1.hp.ToString ();
			textHP2.text = "血量：" + player2.hp.ToString () + " - " + diceDifference.ToString ();
			player2.hp -= diceDifference;
		} else if (diceDifference < 0) { // Player 2 wins
			diceDifference = -1 * diceDifference;
			textHP1.text = "血量：" + player1.hp.ToString () + " - " + diceDifference.ToString ();
			textHP2.text = "血量：" + player2.hp.ToString ();
			player1.hp -= diceDifference;
		} else { // Draw
			textHP1.text = "血量：" + player1.hp.ToString ();
			textHP2.text = "血量：" + player2.hp.ToString ();
		}
		// Check whether game is over
		if (player1.hp <= 0) {
			gameController.setGameIsOver (true);
			gameController.setWinnerNumber (2);
		}
		if (player2.hp <= 0) {
			gameController.setGameIsOver (true);
			gameController.setWinnerNumber (2);
		}
	}

	// Set skill affect according to the player's chosen character
	private void settleSkill(Player player) {
		if (!player.getCharacter ().getSkillTriggered ())
			return;
		if (player.getCharacter ().getName () == "骗子") {
			this.switchDice = !this.switchDice;
		} else if (player.getCharacter ().getName () == "渣渣辉") {
			if (player.getDicePoint () < 6) {
				player.setDicePoint (player.getDicePoint () + 1);
			}
		}
	}
}

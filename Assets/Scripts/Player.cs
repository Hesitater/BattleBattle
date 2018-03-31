using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private int playerNumber; // 1 or 2
	private Character character;
	private int dicePoint = 0;
	public int hp;
	public int sp;

	public Player(Character character, int playerNumber) {
		this.character = character;
		this.playerNumber = playerNumber;
		this.hp = character.getHealth ();
		this.sp = character.getSkillPoint ();
	}

	public void triggerSkill() {
		if (this.character.getSkillPoint () == 0) {
			Debug.Log ("No more skills to trigger.");
			return;
		}
		this.character.setSkillTriggered (true);
		this.character.setSkillPoint (this.character.getSkillPoint () - 1);
	}

	public void untriggerSkill() {
		this.character.setSkillTriggered (false);
	}

	public int rollDice() {
		this.dicePoint = Random.Range (1, 7);
		return this.dicePoint;
	}

	public Character getCharacter() {
		return this.character;
	}

	public int getDicePoint() {
		return this.dicePoint;
	}

	public void setDicePoint(int point) {
		this.dicePoint = point;
	}
}

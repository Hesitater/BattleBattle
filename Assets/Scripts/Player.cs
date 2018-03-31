using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private int playerNumber; // 1 or 2
	private Character character;
	private int dicePoint = 0;

	public Player(Character character, int playerNumber) {
		this.character = character;
		this.playerNumber = playerNumber;
	}

	public void triggerSkill() {
		this.character.setSkillTriggered (true);
	}

	public void untriggerSkill() {
		this.character.setSkillTriggered (false);
	}

	public void rollDice() {
		this.dicePoint = Random.Range (1, 7);
	}

	public Character getCharacter() {
		return this.character;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
	protected int health = 0;
	protected int skillPoint = 0;
	protected bool skillTriggered = false;
	protected string characterName;

	public void setHealth(int health) {
		this.health = health;
	}

	public int getHealth() {
		return this.health;
	}

	public void setSkillPoint(int point) {
		this.skillPoint = point;
	} 

	public int getSkillPoint() {
		return this.skillPoint;
	}

	public void setSkillTriggered(bool isTriggered) {
		this.skillTriggered = isTriggered;
	}

	public bool getSkillTriggered() {
		return this.skillTriggered;
	}

	public string getName() {
		return this.characterName;
	}
}

public class Liar : Character {
	public Liar() {
		this.health = 4;
		this.skillPoint = 3;
		this.characterName = "骗子";
	}
}

public class Hunk : Character {
	// Later version
}

public class Zombie : Character {
	// Later version
}

public class Vanilla : Character {
	public Vanilla() {
		this.health = 5;
		this.skillPoint = 3;
		this.characterName = "渣渣辉";
	}
}
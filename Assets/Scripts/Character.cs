using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character {
	protected int health;
	protected int skillPoint;
	protected bool skillTriggered = false;
	protected string characterName;

	public int getHealth() {
		return this.health;
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
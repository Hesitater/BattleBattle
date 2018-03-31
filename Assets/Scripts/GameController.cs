using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController: MonoBehaviour {
	private Player player1;
	private Player player2;
	public static GameController instance;

	void Awake() {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (this.gameObject);
			return;
		}
		DontDestroyOnLoad (this.gameObject); // Make it alive all the time
	}

	public void setPlayer1(Player player1) {
		this.player1 = player1;
	}

	public Player getPlayer1() {
		return this.player1;
	}

	public void setPlayer2(Player player2) {
		this.player2 = player2;
	}

	public Player getPlayer2() {
		return this.player2;
	}
}

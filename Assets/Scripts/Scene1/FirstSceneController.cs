using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSceneController : SceneController {
	private bool player1IsReady = false;
	private bool player2IsReady = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void setPlayer1IsReady(bool isReady) {
		this.player1IsReady = isReady;
	}

	public bool getPlayer1IsReady() {
		return this.player1IsReady;
	}

	public void setPlayer2IsReady(bool isReady) {
		this.player2IsReady = isReady;
	}

	public bool getPlayer2IsReady() {
		return this.player2IsReady;
	}
}

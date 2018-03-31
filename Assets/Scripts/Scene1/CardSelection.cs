using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardSelection : MonoBehaviour {
	private Button button;
	private bool isPressed = false;
	private Color originalColor;
	public GameObject modal;

	void Start() {
		this.button = GetComponent<Button> ();
		this.originalColor = this.button.image.color;
	}

	public void Click() {
		if (!this.isPressed) {
			this.isPressed = true;
		} else {
			this.isPressed = false;
		}
		this.setColor (this.isPressed);
		this.setReadyState (this.isPressed);
	}

	// Card color settings
	private void setColor(bool pressDown) {
		if (pressDown) {
			this.button.image.color = Color.gray;
		} else {
			this.button.image.color = this.originalColor;
		}
	}

	// Controller settings ready for modal popup & character selections
	private void setReadyState(bool pressDown) {
		FirstSceneController controller = (FirstSceneController)FirstSceneController.instance;
		if (pressDown) {
			if (controller.getPlayer1IsReady() && !controller.getPlayer2IsReady ()) { // Player 1 is ready & Player 2 is not ready
				this.setPlayerState (2, this.button.name);
				this.modal.SetActive (true); // Modal pop up
				// Unable other cards
			} else { // No one has been selected
				this.setPlayerState (1, this.button.name);
				controller.setPlayer1IsReady (true);
			}
		} else {
			if (controller.getPlayer1IsReady() && controller.getPlayer2IsReady ()) { // Both players are ready, default is to unselect player 2
				controller.setPlayer2IsReady (false);
			} else if (controller.getPlayer1IsReady () && !controller.getPlayer2IsReady ()){ // Only player 1 is ready
				controller.setPlayer1IsReady (false);
			}
		}
	}

	// Player number is restricted to 1 or 2
	private void setPlayerState(int playerNumber, string characterName) {
		// Set character information
		Character character = null;
		switch (characterName) {
		case "LiarCard":
			character = new Liar ();
			break;
		case "VanillaCard":
			character = new Vanilla ();
			break;
		}
			
		// Set player information
		Player player = new Player (character, 1);
		if (playerNumber == 1) {
			GameController.instance.setPlayer1 (player);
		} else if (playerNumber == 2){
			GameController.instance.setPlayer2 (player);
		} else {
			Debug.Log ("Player number should only be either 1 or 2.");
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour {
	private Scene currentScene;

	public void Click () {
		this.currentScene = SceneManager.GetActiveScene ();
		switch(this.currentScene.name) {
		case "Character Selections":
			{
				SceneManager.LoadSceneAsync ("Play Field");
				break;
			}
		case "Play Field":
			{
				SceneManager.LoadSceneAsync ("Transition");
				break;
			}
		case "Transition":
			{
				SceneManager.LoadSceneAsync ("Play Field 2");
				break;
			}
		case "Play Field 2":
			{
				SceneManager.LoadSceneAsync ("Turn Check");
				break;
			}
		case "Turn Check":
			{
				if (!GameController.instance.getGameIsOver ()) {
					SceneManager.LoadSceneAsync ("Play Field");
				} else {
					SceneManager.LoadSceneAsync ("Game Result");
				}
				break;
			}
		case "Game Result":
			{
				SceneManager.LoadSceneAsync ("Character Selection");
				break;
			}
		}
	}
}

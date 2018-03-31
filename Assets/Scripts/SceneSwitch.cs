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
				SceneManager.LoadSceneAsync ("Play Field2");
				break;
			}
		case "Play Field2":
			{
				SceneManager.LoadSceneAsync ("Turn Check");
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

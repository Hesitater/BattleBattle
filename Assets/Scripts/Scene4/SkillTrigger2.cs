using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillTrigger2 : MonoBehaviour {
	public void Click() {
		Button button = GetComponent<Button> ();
		GameController.instance.getPlayer2 ().triggerSkill ();
		button.enabled = false;
		button.image.color = Color.black;
	}
}

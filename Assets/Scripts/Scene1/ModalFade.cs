using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModalFade : MonoBehaviour {
	public GameObject modal;

	public void Click() {
		this.modal.SetActive (false);
	}
}

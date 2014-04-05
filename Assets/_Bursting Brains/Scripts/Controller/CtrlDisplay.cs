using UnityEngine;
using System.Collections;

public class CtrlDisplay : Ctrl_Base {

	tk2dTextMesh tmText;

	void Awake() {
		tmText = transform.FindChild("Text").GetComponent<tk2dTextMesh>();
	}

	public void DisplayString(string text) {
		tmText.text = text;
		tmText.Commit();
	}
}
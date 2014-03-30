using UnityEngine;
using System.Collections;

public class CtrlDisplay : Ctrl_Base {

	tk2dTextMesh tmText;

	void Awake() {
		tmText = transform.FindChild("Text").GetComponent<tk2dTextMesh>();
	}

	public void AddNumber(char numAsChar) {
		tmText.text += numAsChar;
		tmText.Commit();
	}

	public void Clear() {
		tmText.text = "";
		tmText.Commit();
	}
}

using UnityEngine;
using System.Collections;

public class CtrlDisplay : Ctrl_Base {

	tk2dTextMesh text2D;
	TextMesh text3D;

	void Awake() {
		text2D = transform.FindChild("Text 2D").GetComponent<tk2dTextMesh>();
		text3D = transform.FindChild("Text 3D").GetComponent<TextMesh>();
	}

	public void DisplayString(string numberAsString) {
		double number = double.Parse(numberAsString);
		numberAsString = number.ToString(Constants.DISPLAY_STRING_FORMATTER);

		text2D.text = numberAsString;
		text2D.Commit();

		text3D.text = numberAsString;
	}
}
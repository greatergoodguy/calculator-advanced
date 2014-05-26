using UnityEngine;
using System.Collections;

public class CtrlDisplay : Ctrl_Base {
	
	TextMesh tmText_Main;
	TextMesh tmOperator_Main;

	TextMesh tmText_Recent1;
	TextMesh tmOperator_Recent1;

	TextMesh tmText_Recent2;
	TextMesh tmOperator_Recent2;

	TextMesh tmText_Recent3;
	TextMesh tmOperator_Recent3;

	void Awake() {
		tmText_Main = transform.FindChild("Main").FindChild("Text").GetComponent<TextMesh>();
		tmOperator_Main = transform.FindChild("Main").FindChild("Operator").GetComponent<TextMesh>();

		tmText_Recent1 = transform.FindChild("Recent 1").FindChild("Text").GetComponent<TextMesh>();
		tmOperator_Recent1 = transform.FindChild("Recent 1").FindChild("Operator").GetComponent<TextMesh>();

		tmText_Recent2 = transform.FindChild("Recent 2").FindChild("Text").GetComponent<TextMesh>();
		tmOperator_Recent2 = transform.FindChild("Recent 2").FindChild("Operator").GetComponent<TextMesh>();

		tmText_Recent3 = transform.FindChild("Recent 3").FindChild("Text").GetComponent<TextMesh>();
		tmOperator_Recent3 = transform.FindChild("Recent 3").FindChild("Operator").GetComponent<TextMesh>();
	}

	public void DisplayString(string numberAsString) {
		double number = double.Parse(numberAsString);
		numberAsString = number.ToString(Constants.DISPLAY_STRING_FORMATTER);

		tmText_Main.text = numberAsString;
	}

	public void DisplayOperator(Operator_BB operator_bb) {
		string operatorText = "";

		switch(operator_bb) {
		case Operator_BB.Plus:
			operatorText = "+";
			break;
		case Operator_BB.Minus:
			operatorText = "-";
			break;
		case Operator_BB.Multiply:
			operatorText = "\u00D7";
			break;
		case Operator_BB.Divide:
			operatorText = "÷";
			break;
		case Operator_BB.None:
			break;
		default:
			break;
		}

		tmOperator_Main.text = operatorText;
	}

	public void Shift() {
		tmText_Recent3.text = tmText_Recent2.text;
		tmOperator_Recent3.text = tmOperator_Recent2.text;

		tmText_Recent2.text = tmText_Recent1.text;
		tmOperator_Recent2.text = tmOperator_Recent1.text;

		tmText_Recent1.text = tmText_Main.text;
		tmOperator_Recent1.text = tmOperator_Main.text;

		tmText_Main.text = "0";
		tmOperator_Main.text = "";
	}

	public void DisplayString_Phase4Equals(string numberAsString) {
		string numberBaseAsString = tmText_Main.text;
		string numberMultiplierAsString = tmText_Recent1.text;
		string operatorAsString = tmOperator_Recent1.text;

		Shift();

		tmOperator_Recent2.text = operatorAsString;
		tmText_Recent2.text = numberBaseAsString;
		tmOperator_Recent1.text = "=";
		tmText_Recent1.text = numberMultiplierAsString;

		DisplayString(numberAsString);
	}
}
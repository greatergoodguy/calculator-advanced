using UnityEngine;
using System.Collections;

public class Phase1 : Phase_Base {

	CtrlProcessor ctrlProcessor;

	string numberAsString = "0";

	public Phase1 (CtrlProcessor ctrlProcessor) {
		this.ctrlProcessor = ctrlProcessor;
	}

	public override void Clear() {
		numberAsString = "0";
		ctrlProcessor.DisplayString(numberAsString);
	}

	public override void Digit(char digit) {
		if(numberAsString == "0") {
			numberAsString = "" + digit;}
		else {
			numberAsString += digit;}

		ctrlProcessor.DisplayString(numberAsString);
	}

	public override void Decimal() {
		if(numberAsString.Contains(".")) {
			return;}

		numberAsString += ".";
		ctrlProcessor.DisplayString(numberAsString);
	}
	
	public override void Reverse() {
		double number = double.Parse(numberAsString) * -1;
		numberAsString = number.ToString();

		ctrlProcessor.DisplayString(numberAsString);
	}

	public override void Plus() {
		Phase_Base phase2 = ctrlProcessor.switchTo_Phase2();
		phase2.Plus();
	}

	public override void Minus() {
		Phase_Base phase2 = ctrlProcessor.switchTo_Phase2();
		phase2.Minus();
	}

	public override void Divide() {
		Phase_Base phase2 = ctrlProcessor.switchTo_Phase2();
		phase2.Divide();
	}

	public override void Multiply() {
		Phase_Base phase2 = ctrlProcessor.switchTo_Phase2();
		phase2.Multiply();
	}

	
	public override void Backspace() {
		if(numberAsString.Length > 1) {
			numberAsString = numberAsString.Remove(numberAsString.Length - 1);}
		else {
			numberAsString = "0";}

		if(numberAsString == "-") {
			numberAsString = "0";}

		ctrlProcessor.DisplayString(numberAsString);
	}

}

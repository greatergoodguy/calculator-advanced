using UnityEngine;
using System.Collections;

public class Phase_Base_Digit : Phase_Base {

	protected CtrlProcessor ctrlProcessor;
	
	public Phase_Base_Digit (CtrlProcessor ctrlProcessor) {
		this.ctrlProcessor = ctrlProcessor;
	}

	public void reset() {
		numberAsString = "0";
	}
	
	public void overrideNumberAsString(string numberAsString) {
		this.numberAsString = numberAsString;
	}
	
	public override void Clear() {
		reset();
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

	public override void Backspace() {
		if(numberAsString.Length > 1) {
			numberAsString = numberAsString.Remove(numberAsString.Length - 1);}
		else {
			reset();}
		
		if(numberAsString == "-" || numberAsString == "-0") {
			reset();}
		
		ctrlProcessor.DisplayString(numberAsString);
	}
}

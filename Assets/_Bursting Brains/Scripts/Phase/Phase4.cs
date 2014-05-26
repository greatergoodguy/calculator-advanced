using UnityEngine;
using System.Collections;

public class Phase4 : Phase_Base {

	CtrlProcessor ctrlProcessor;

	public Phase4 (CtrlProcessor ctrlProcessor) {
		this.ctrlProcessor = ctrlProcessor;
	}

	public override void Clear() {
		base.Clear();
		Phase_Base phase1 = ctrlProcessor.switchTo_Phase1();
		phase1.Clear();
	}	

	public override void Digit(char digit) {
		Phase1 phase1 = ctrlProcessor.switchTo_Phase1();
		phase1.reset();
		phase1.Digit(digit);
	}

	public override void Decimal(){
		Phase1 phase1 = ctrlProcessor.switchTo_Phase1();
		phase1.reset();
		phase1.Decimal();
	}

	public override void Equals() {
		Operator_BB operator_bb = ctrlProcessor.getPhase2_Operator();

		string num1_string = ctrlProcessor.getPhase1_Number();
		string num2_string = ctrlProcessor.getPhase3_Number();

		double num1 = double.Parse(num1_string);
		double num2 = double.Parse(num2_string);

		double result = 0;

		switch(operator_bb) {
		case Operator_BB.Plus:
			result = num1 + num2;
			break;

		case Operator_BB.Minus:
			result = num1 - num2;
			break;

		case Operator_BB.Multiply:
			result = num1 * num2;
			break;

		case Operator_BB.Divide:
			result = num1 / num2;
			break;

		case Operator_BB.None:
			break;

		}
		numberAsString = result.ToString();

		ctrlProcessor.DisplayString_Phase4Equals(numberAsString);

		ctrlProcessor.overrideP1withP4();

	}

	public override void Reverse() {
		Phase1 phase1 = ctrlProcessor.switchTo_Phase1();
		phase1.Reverse();
	}

	public override void Plus() {
		Phase2 phase2 = ctrlProcessor.switchTo_Phase2();
		phase2.Plus();
	}

	public override void Minus() {
		Phase2 phase2 = ctrlProcessor.switchTo_Phase2();
		phase2.Minus();
	}

	public override void Divide() {
		Phase2 phase2 = ctrlProcessor.switchTo_Phase2();
		phase2.Divide();
	}

	public override void Multiply() {
		Phase2 phase2 = ctrlProcessor.switchTo_Phase2();
		phase2.Multiply();
	}

	public override void Backspace() {
		Phase1 phase1 = ctrlProcessor.switchTo_Phase1();
		phase1.Backspace();
	}
}

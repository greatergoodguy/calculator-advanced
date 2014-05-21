using UnityEngine;
using System.Collections;

public class Phase4 : Phase1 {
	
	public Phase4 (CtrlProcessor ctrlProcessor) : base(ctrlProcessor) {
	}

	public override void Clear() {
		base.Clear();
		Phase_Base phase1 = ctrlProcessor.switchTo_Phase1();
		phase1.Clear();
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
		ctrlProcessor.DisplayString(numberAsString);

		ctrlProcessor.overrideP1withP4();
	}

	public override void Plus() {
	}

	public override void Minus() {
	}

	public override void Divide() {
	}

	public override void Multiply() {
	}
}

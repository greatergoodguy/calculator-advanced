using UnityEngine;
using System.Collections;

public class Phase2 : Phase_Base {
	
	CtrlProcessor ctrlProcessor;

	Operator_BB operator_bb = Operator_BB.None;

	public Phase2(CtrlProcessor ctrlProcessor) {
		this.ctrlProcessor = ctrlProcessor;
	}

	public override void Clear() {
		Phase_Base phase1 = ctrlProcessor.switchTo_Phase1();
		phase1.Clear();
	}

	public override void Digit(char digit) {
	}

	public override void Decimal() {
	}

	
	public override void Reverse() {
		Phase_Base phase1 = ctrlProcessor.switchTo_Phase1();
		phase1.Reverse();
	}

	public override void Plus() {
		operator_bb = Operator_BB.Plus;
	}

	public override void Minus() {
		operator_bb = Operator_BB.Minus;
	}

	public override void Divide() {
		operator_bb = Operator_BB.Divide;
	}

	public override void Multiply() {
		operator_bb = Operator_BB.Multiply;
	}

	public override void Backspace() {
		Phase_Base phase1 = ctrlProcessor.switchTo_Phase1();
		phase1.Backspace();
	}

}

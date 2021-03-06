﻿using UnityEngine;
using System.Collections;

public class Phase2 : Phase_Base {
	
	CtrlProcessor ctrlProcessor;

	Operator_BB operator_bb = Operator_BB.None;

	public Phase2(CtrlProcessor ctrlProcessor) {
		this.ctrlProcessor = ctrlProcessor;
	}

	public Operator_BB getOperator() {
		return operator_bb;
	}

	public override void Clear() {
		Phase_Base phase1 = ctrlProcessor.switchTo_Phase1();
		phase1.Clear();
	}

	public override void Digit(char digit) {
		Phase3 phase3 = ctrlProcessor.switchTo_Phase3();
		phase3.reset();
		phase3.Digit(digit);
	}

	public override void Decimal() {
		Phase3 phase3 = ctrlProcessor.switchTo_Phase3();
		phase3.reset();
		phase3.Decimal();
	}

	
	public override void Reverse() {
		Phase_Base phase1 = ctrlProcessor.switchTo_Phase1();
		phase1.Reverse();
	}

	public override void Plus() {
		operator_bb = Operator_BB.Plus;
		ctrlProcessor.DisplayOperator(operator_bb);
	}

	public override void Minus() {
		operator_bb = Operator_BB.Minus;
		ctrlProcessor.DisplayOperator(operator_bb);
	}

	public override void Divide() {
		operator_bb = Operator_BB.Divide;
		ctrlProcessor.DisplayOperator(operator_bb);
	}

	public override void Multiply() {
		operator_bb = Operator_BB.Multiply;
		ctrlProcessor.DisplayOperator(operator_bb);
	}

	public override void Backspace() {
		operator_bb = Operator_BB.None;
		ctrlProcessor.DisplayOperator(operator_bb);

		Phase_Base phase1 = ctrlProcessor.switchTo_Phase1();
		phase1.Backspace();
	}

}

using UnityEngine;
using System.Collections;

public class Phase1 : Phase_Base_Digit {
	
	public Phase1 (CtrlProcessor ctrlProcessor) : base(ctrlProcessor) {
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

	public override void Equals (){
		ctrlProcessor.DisplayShift();
	}
}

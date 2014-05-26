using UnityEngine;
using System.Collections;

public class Phase3 : Phase_Base_Digit {

	public Phase3 (CtrlProcessor ctrlProcessor) : base(ctrlProcessor) {
	}

	public override void Clear() {
		base.Clear();
		Phase_Base phase1 = ctrlProcessor.switchTo_Phase1();
		phase1.Clear();
	}	

	public override void Equals() {
		Phase_Base phase4 = ctrlProcessor.switchTo_Phase4();
		phase4.Equals();
	}

	public override void Plus() {
		Phase_Base phase4 = ctrlProcessor.switchTo_Phase4();
		phase4.Equals();
		phase4.Plus();
	}
	
	public override void Minus() {
		Phase_Base phase4 = ctrlProcessor.switchTo_Phase4();
		phase4.Equals();
		phase4.Minus();
	}
	
	public override void Divide() {
		Phase_Base phase4 = ctrlProcessor.switchTo_Phase4();
		phase4.Equals();
		phase4.Divide();
	}
	
	public override void Multiply() {
		Phase_Base phase4 = ctrlProcessor.switchTo_Phase4();
		phase4.Equals();
		phase4.Multiply();
	}
}

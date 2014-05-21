using UnityEngine;
using System.Collections;

public class Phase3 : Phase1 {
	
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
	}

	public override void Minus() {
	}

	public override void Divide() {
	}

	public override void Multiply() {
	}
}

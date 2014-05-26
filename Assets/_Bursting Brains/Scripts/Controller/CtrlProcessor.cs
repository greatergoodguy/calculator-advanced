using UnityEngine;
using System.Collections;

public class CtrlProcessor : Ctrl_Base {
	
	CtrlDisplay ctrlDisplay;

	Phase1 phase1;
	Phase2 phase2;
	Phase3 phase3;
	Phase4 phase4;

	Phase_Base activePhase;


	void Awake() {
		ctrlDisplay = GameObject.Find("Display").GetComponent<CtrlDisplay>();

		phase1 = new Phase1(this);
		phase2 = new Phase2(this);
		phase3 = new Phase3(this);
		phase4 = new Phase4(this);

		activePhase = phase1;
	}

	// ======================
	// Phase Switch Methods
	// ======================
	public Phase1 switchTo_Phase1() {
		DisplayOperator(Operator_BB.None);

		activePhase = phase1;
		return phase1;
	}

	public Phase2 switchTo_Phase2() {
		activePhase = phase2;
		return phase2;
	}

	public Phase3 switchTo_Phase3() {
		DisplayShift();

		activePhase = phase3;
		return phase3;
	}

	public Phase4 switchTo_Phase4() {
		activePhase = phase4;
		return phase4;
	}

	public void overrideP1withP4() {
		string numberAsString = phase4.getNumberAsString();
		phase1.overrideNumberAsString(numberAsString);
	}

	// ======================
	// Getter Methods
	// ======================
	public string getPhase1_Number() {
		return phase1.getNumberAsString();
	}

	public Operator_BB getPhase2_Operator() {
		return phase2.getOperator();
	}

	public string getPhase3_Number() {
		return phase3.getNumberAsString();
	}

	// ======================
	// Display Helper Methods
	// ======================
	public void DisplayString(string text) {
		ctrlDisplay.DisplayString(text);
	}

	public void DisplayOperator(Operator_BB operator_bb) {
		ctrlDisplay.DisplayOperator(operator_bb);
	}

	public void DisplayShift() {
		ctrlDisplay.Shift();
	}

	public void DisplayString_Phase4Equals(string text) {
		ctrlDisplay.DisplayString_Phase4Equals(text);
	}

	// ======================
	// Phase Wrapper Methods
	// ======================
	public void Clear() {
		activePhase.Clear();
	}

	public void Digit(char digit) {
		activePhase.Digit(digit);
	}

	public void Decimal() {
		activePhase.Decimal();
	}

	public void Equals() {
		activePhase.Equals();
	}
	
	public void Reverse() {
		activePhase.Reverse();
	}

	public void Plus() {
		activePhase.Plus();
	}

	public void Minus() {
		activePhase.Minus();
	}

	public void Multiply() {
		activePhase.Multiply();
	}

	public void Divide() {
		activePhase.Divide();
	}

	public void Backspace() {
		activePhase.Backspace();
	}
}

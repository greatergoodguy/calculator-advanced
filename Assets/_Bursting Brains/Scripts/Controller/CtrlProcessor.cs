using UnityEngine;
using System.Collections;

public class CtrlProcessor : Ctrl_Base {
	
	CtrlDisplay ctrlDisplay;

	Phase_Base phase1;
	Phase_Base phase2;

	Phase_Base activePhase;


	void Awake() {
		ctrlDisplay = GameObject.Find("Display").GetComponent<CtrlDisplay>();

		phase1 = new Phase1(this);
		phase2 = new Phase2(this);

		activePhase = phase1;
	}

	// ======================
	// Phase Switch Methods
	// ======================
	public Phase_Base switchTo_Phase1() {
		activePhase = phase1;
		return activePhase;
	}

	public Phase_Base switchTo_Phase2() {
		activePhase = phase2;
		return activePhase;
	}

	// ======================
	// Display Helper Methods
	// ======================
	public void DisplayString(string text) {
		ctrlDisplay.DisplayString(text);
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

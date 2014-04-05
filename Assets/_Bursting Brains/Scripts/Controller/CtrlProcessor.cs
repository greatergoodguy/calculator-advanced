using UnityEngine;
using System.Collections;

public class CtrlProcessor : Ctrl_Base {

	enum Operator{
		Plus,
		Minus,
		Multiply,
		Divide,
		None
	}

	CtrlDebug ctrlDebug;
	CtrlDisplay ctrlDisplay;

	Operator operator_bb;
	string currentNumber;
	string resultNumber;

	void Awake() {
		ctrlDebug = GameObject.Find("Debug").GetComponent<CtrlDebug>();
		ctrlDisplay = GameObject.Find("Display").GetComponent<CtrlDisplay>();

		operator_bb = Operator.None;
		currentNumber = "";
		resultNumber = "";
	}

	public void CurrentNumber_AppendNumber(char numAsChar) {
		UtilLogger.LogInfo("CtrlProcessor", "CurrentNumber_AppendNumber()");
		ctrlDebug.LogInfo("AppendNumber: " + numAsChar);

		currentNumber += numAsChar;
		ctrlDisplay.DisplayString(currentNumber);
	}

	public void CurrentNumber_AppendDecimal() {
		UtilLogger.LogInfo("CtrlProcessor", "CurrentNumber_AppendDecimal()");
		ctrlDebug.LogInfo("AppendDecimal");
	}

	// ==================
	// Symbols
	// ==================
	public void Symbol_Clear() {
		UtilLogger.LogInfo("CtrlProcessor", "Symbol_Clear()");
		ctrlDebug.LogInfo("Clear");

		currentNumber = "";
		resultNumber = "";
		ctrlDisplay.DisplayString("0");
	}

	public void Symbol_Equals() {
		UtilLogger.LogInfo("CtrlProcessor", "Symbol_Equals()");
		ctrlDebug.LogInfo("Equals");
	}

	public void Symbol_Backspace() {
		UtilLogger.LogInfo("CtrlProcessor", "Symbol_Backspace()");
		ctrlDebug.LogInfo("Backspace");

		if(currentNumber.Length != 0) {
			currentNumber = currentNumber.Remove(currentNumber.Length - 1);}

		if(currentNumber.Length == 0) {
			ctrlDisplay.DisplayString("0");}
		else {
			ctrlDisplay.DisplayString(currentNumber);}
	}
	
	public void Symbol_ReverseSign() {
		UtilLogger.LogInfo("CtrlProcessor", "Symbol_ReverseSign()");
		ctrlDebug.LogInfo("ReverseSign");
	}

	public void Symbol_Plus() {
		UtilLogger.LogInfo("CtrlProcessor", "Symbol_Plus()");
		ctrlDebug.LogInfo("Plus");

		ClearCurrentNumberString();
	}

	public void Symbol_Minus() {
		UtilLogger.LogInfo("CtrlProcessor", "Symbol_Minus()");
		ctrlDebug.LogInfo("Minus");

		ClearCurrentNumberString();
	}

	public void Symbol_Multiply() {
		UtilLogger.LogInfo("CtrlProcessor", "Symbol_Multiply()");
		ctrlDebug.LogInfo("Multiply");

		ClearCurrentNumberString();
	}

	public void Symbol_Divide() {
		UtilLogger.LogInfo("CtrlProcessor", "Symbol_Divide()");
		ctrlDebug.LogInfo("Divide");

		ClearCurrentNumberString();
	}

	// ==================
	// Helper
	// ==================
	
	private void ClearCurrentNumberString() {
		currentNumber = "";
	}
}

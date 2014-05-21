using UnityEngine;
using System.Collections;

public class CtrlProcessor_Deprecated : Ctrl_Base {

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

	bool isResultNumberDisplayed = false;

	int consecutiveEqualsCounter = 0;

	void Awake() {
		ctrlDebug = GameObject.Find("Debug").GetComponent<CtrlDebug>();
		ctrlDisplay = GameObject.Find("Display").GetComponent<CtrlDisplay>();
	}

	void Start() {
		Symbol_Clear();
	}

	public void CurrentNumber_AppendNumber(char numAsChar) {
		currentNumber += numAsChar;
		ctrlDisplay.DisplayString(currentNumber);
		isResultNumberDisplayed = false;

		UtilLogger.LogInfo("CtrlProcessor", "CurrentNumber_AppendNumber(): " + currentNumber);
		ctrlDebug.LogInfo("AppendNumber: " + numAsChar);
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
		resultNumber = "0";
		ctrlDisplay.DisplayString(resultNumber);
		isResultNumberDisplayed = true;

		operator_bb = Operator.None;
		consecutiveEqualsCounter = 0;
	}

	public void Symbol_Equals() {

		double currentNumberAsDouble = 0;
		double resultNumberAsDouble = double.Parse(resultNumber);

		switch(operator_bb) {
		case Operator.Plus:
			if(currentNumber.Length != 0) {
				currentNumberAsDouble = double.Parse(currentNumber);}
			
			resultNumberAsDouble += currentNumberAsDouble;
			resultNumber = resultNumberAsDouble.ToString();
			
			ctrlDisplay.DisplayString(resultNumber);
			isResultNumberDisplayed = true;
			break;

		case Operator.Minus:
			if(currentNumber.Length != 0) {
				currentNumberAsDouble = double.Parse(currentNumber);}
			
			resultNumberAsDouble -= currentNumberAsDouble;
			resultNumber = resultNumberAsDouble.ToString();
			
			ctrlDisplay.DisplayString(resultNumber);
			isResultNumberDisplayed = true;
			break;

		case Operator.Multiply:
			if(currentNumber.Length != 0) {
				currentNumberAsDouble = double.Parse(currentNumber);}
			
			resultNumberAsDouble *= currentNumberAsDouble;
			resultNumber = resultNumberAsDouble.ToString();
			
			ctrlDisplay.DisplayString(resultNumber);
			isResultNumberDisplayed = true;
			break;

		case Operator.Divide:
			if(currentNumber.Length != 0) {
				currentNumberAsDouble = double.Parse(currentNumber);}
			
			resultNumberAsDouble /= currentNumberAsDouble;
			resultNumber = resultNumberAsDouble.ToString();
			
			ctrlDisplay.DisplayString(resultNumber);
			isResultNumberDisplayed = true;
			break;
			
		case Operator.None:
			if(currentNumber.Length != 0) {
				currentNumberAsDouble = double.Parse(currentNumber);}

			resultNumber = currentNumberAsDouble.ToString();
			ctrlDisplay.DisplayString(resultNumber);
			isResultNumberDisplayed = true;
			break;
		}

		consecutiveEqualsCounter++;

		UtilLogger.LogInfo("CtrlProcessor", "currentNumber, resultNumber: " + currentNumber + ", " + resultNumber);
		ctrlDebug.LogInfo("Equals");
	}

	public void Symbol_Backspace() {
		UtilLogger.LogInfo("CtrlProcessor", "Symbol_Backspace()");
		ctrlDebug.LogInfo("Backspace");

		if(currentNumber.Length != 0) {
			currentNumber = currentNumber.Remove(currentNumber.Length - 1);}

		if(currentNumber.Length == 0) {
			resultNumber = "0";
			ctrlDisplay.DisplayString(resultNumber);
			isResultNumberDisplayed = true;}
		else {
			ctrlDisplay.DisplayString(currentNumber);
			isResultNumberDisplayed = false;}

		operator_bb = Operator.None;
	}
	
	public void Symbol_ReverseSign() {
		UtilLogger.LogInfo("CtrlProcessor", "Symbol_ReverseSign()");
		ctrlDebug.LogInfo("ReverseSign");

		if(isResultNumberDisplayed) {
			double resultNumberAsDouble = double.Parse(resultNumber) * -1;
			resultNumber = resultNumberAsDouble.ToString();
			ctrlDisplay.DisplayString(resultNumber);
			isResultNumberDisplayed = true;

		}
		else {
			double currentNumberAsDouble = 0;
			if(currentNumber.Length != 0) {
				currentNumberAsDouble = double.Parse(currentNumber) * -1;
				currentNumber = currentNumberAsDouble.ToString();
				ctrlDisplay.DisplayString(currentNumber);
				isResultNumberDisplayed = false;
			}
		}
	}

	public void Symbol_Plus() {
		UtilLogger.LogInfo("CtrlProcessor", "Symbol_Plus(): " + operator_bb);
		ctrlDebug.LogInfo("Plus");

		if(consecutiveEqualsCounter == 0) {
			Symbol_Equals();}

		ClearCurrentNumberString();
		operator_bb = Operator.Plus;
		consecutiveEqualsCounter = 0;
	}

	public void Symbol_Minus() {
		UtilLogger.LogInfo("CtrlProcessor", "Symbol_Minus()");
		ctrlDebug.LogInfo("Minus");

		if(consecutiveEqualsCounter == 0) {
			Symbol_Equals();}

		ClearCurrentNumberString();
		operator_bb = Operator.Minus;
		consecutiveEqualsCounter = 0;
	}

	public void Symbol_Multiply() {
		UtilLogger.LogInfo("CtrlProcessor", "Symbol_Multiply()");
		ctrlDebug.LogInfo("Multiply");

		if(consecutiveEqualsCounter == 0) {
			Symbol_Equals();}

		ClearCurrentNumberString();
		operator_bb = Operator.Multiply;
		consecutiveEqualsCounter = 0;
	}

	public void Symbol_Divide() {
		UtilLogger.LogInfo("CtrlProcessor", "Symbol_Divide()");
		ctrlDebug.LogInfo("Divide");

		if(consecutiveEqualsCounter == 0) {
			Symbol_Equals();}

		ClearCurrentNumberString();
		operator_bb = Operator.Divide;
		consecutiveEqualsCounter = 0;
	}

	// ==================
	// Helper
	// ==================
	
	private void ClearCurrentNumberString() {
		currentNumber = "";
	}
}

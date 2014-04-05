using UnityEngine;
using System.Collections;

public class CtrlNumberPad : Ctrl_Base {
	
	CtrlProcessor ctrlProcessor;

	void Start() {
		ctrlProcessor = GameObject.Find("Processor").GetComponent<CtrlProcessor>();
	}

	//=================
	// Numbers
	//=================
	public void ButtonPressed_0() 		{Display_AppendNumber('0');}
	public void ButtonPressed_1() 		{Display_AppendNumber('1');}
	public void ButtonPressed_2() 		{Display_AppendNumber('2');}
	public void ButtonPressed_3() 		{Display_AppendNumber('3');}
	public void ButtonPressed_4() 		{Display_AppendNumber('4');}
	public void ButtonPressed_5() 		{Display_AppendNumber('5');}
	public void ButtonPressed_6() 		{Display_AppendNumber('6');}
	public void ButtonPressed_7() 		{Display_AppendNumber('7');}
	public void ButtonPressed_8() 		{Display_AppendNumber('8');}
	public void ButtonPressed_9() 		{Display_AppendNumber('9');}
	
	public void Display_AppendNumber(char numAsChar) {
		ctrlProcessor.CurrentNumber_AppendNumber(numAsChar);
	}

	public void ButtonPressed_Decimal() {
		ctrlProcessor.CurrentNumber_AppendDecimal();
	}

	//=================
	// Symbols
	//=================
	public void Symbol_Clear() {		ctrlProcessor.Symbol_Clear();}
	public void Symbol_Equals() {		ctrlProcessor.Symbol_Equals();}
	public void Symbol_Backspace() {	ctrlProcessor.Symbol_Backspace();}
	public void Symbol_ReverseSign() {	ctrlProcessor.Symbol_ReverseSign();}
	public void Symbol_Plus() {			ctrlProcessor.Symbol_Plus();}
	public void Symbol_Minus() {		ctrlProcessor.Symbol_Minus();}
	public void Symbol_Multiply() {		ctrlProcessor.Symbol_Multiply();}
	public void Symbol_Divide() {		ctrlProcessor.Symbol_Divide();}
}

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
	public void ButtonPressed_0() 		{Digit('0');}
	public void ButtonPressed_1() 		{Digit('1');}
	public void ButtonPressed_2() 		{Digit('2');}
	public void ButtonPressed_3() 		{Digit('3');}
	public void ButtonPressed_4() 		{Digit('4');}
	public void ButtonPressed_5() 		{Digit('5');}
	public void ButtonPressed_6() 		{Digit('6');}
	public void ButtonPressed_7() 		{Digit('7');}
	public void ButtonPressed_8() 		{Digit('8');}
	public void ButtonPressed_9() 		{Digit('9');}
	
	private void Digit(char digit) {
		ctrlProcessor.Digit(digit);
	}

	public void ButtonPressed_Decimal() {
		ctrlProcessor.Decimal();
	}

	//=================
	// Symbols
	//=================
	public void Symbol_Clear() {		ctrlProcessor.Clear();}
	public void Symbol_Equals() {		ctrlProcessor.Equals();}
	public void Symbol_Backspace() {	ctrlProcessor.Backspace();}
	public void Symbol_ReverseSign() {	ctrlProcessor.Reverse();}
	public void Symbol_Plus() {			ctrlProcessor.Plus();}
	public void Symbol_Minus() {		ctrlProcessor.Minus();}
	public void Symbol_Multiply() {		ctrlProcessor.Multiply();}
	public void Symbol_Divide() {		ctrlProcessor.Divide();}

	public void Clear(){}
	public void Digit(){}
	public void Decimal(){}
	public void Equals(){}
	
	public void Reverse(){}
	public void Plus(){}
	public void Minus(){}
	public void Multiply(){}
	public void Divide(){}
	public void Backspace(){}
}

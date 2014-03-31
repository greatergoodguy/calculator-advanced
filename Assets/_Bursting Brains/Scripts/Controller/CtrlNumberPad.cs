using UnityEngine;
using System.Collections;

public class CtrlNumberPad : Ctrl_Base {

	string TAG = "CtrlNumberPad";

	CtrlDisplay ctrlDisplay;

	void Start() {
		ctrlDisplay = GameObject.Find("Display").GetComponent<CtrlDisplay>();
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
	public void ButtonPressed_Decimal() {Display_AppendNumber('.');}

	
	public void Display_AppendNumber(char numAsChar) {
		//UtilLogger.LogInfo(TAG, numAsChar);
		ctrlDisplay.AppendNumber(numAsChar);
	}

	//=================
	// Symbols
	//=================
	public void Symbol_Clear() {
		ctrlDisplay.Clear();
	}

	public void Symbol_Plus() {
		ctrlDisplay.Plus();
	}

	public void Symbol_Equals_BB() {
		ctrlDisplay.Equals_BB();
	}
}

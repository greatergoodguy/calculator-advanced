using UnityEngine;
using System.Collections;

public class CtrlNumberPad : Ctrl_Base {

	string TAG = "CtrlNumberPad";

	CtrlDisplay ctrlDisplay;

	void Start() {
		ctrlDisplay = GameObject.Find("Display").GetComponent<CtrlDisplay>();
	}

	public void ButtonPressed_0() 		{Display_AddNumber('0');}
	public void ButtonPressed_1() 		{Display_AddNumber('1');}
	public void ButtonPressed_2() 		{Display_AddNumber('2');}
	public void ButtonPressed_3() 		{Display_AddNumber('3');}
	public void ButtonPressed_4() 		{Display_AddNumber('4');}
	public void ButtonPressed_5() 		{Display_AddNumber('5');}
	public void ButtonPressed_6() 		{Display_AddNumber('6');}
	public void ButtonPressed_7() 		{Display_AddNumber('7');}
	public void ButtonPressed_8() 		{Display_AddNumber('8');}
	public void ButtonPressed_9() 		{Display_AddNumber('9');}
	//public void ButtonPressed_Decimal() {Display_AddNumber('.');}
	public void ButtonPressed_Decimal() {Display_Clear();}

	public void Display_AddNumber(char numAsChar) {
		UtilLogger.LogInfo(TAG, numAsChar);

		ctrlDisplay.AddNumber(numAsChar);
	}

	public void Display_Clear() {
		ctrlDisplay.Clear();
	}
}

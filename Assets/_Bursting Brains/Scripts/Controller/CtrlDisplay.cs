using UnityEngine;
using System.Collections;

public class CtrlDisplay : Ctrl_Base {

	CtrlDebug ctrlDebug;

	double result_Total 	= 0;
	double result_Current 	= 0;

	tk2dTextMesh tmTextEquation;
	tk2dTextMesh tmTextSolution;

	void Awake() {
		ctrlDebug = GameObject.Find("Debug").GetComponent<CtrlDebug>();
		tmTextEquation = transform.FindChild("1 Text Equation").GetComponent<tk2dTextMesh>();
		tmTextSolution = transform.FindChild("2 Text Solution").GetComponent<tk2dTextMesh>();
	}

	void Start() {
		Clear();
	}

	//=================
	// Numbers
	//=================
	public void AppendNumber(char numAsChar) {
		LogCurrentResult(); 

		UtilLogger.LogInfo("CtrlDisplay", "AppendNumber()");
		ctrlDebug.LogInfo("AppendNumber");


		tmTextEquation.text += numAsChar;
		tmTextEquation.Commit();

		result_Current = double.Parse(tmTextEquation.text);	
	}

	//=================
	// Symbols
	//=================
	public void Clear() {
		LogCurrentResult(); 

		UtilLogger.LogInfo("CtrlDisplay", "Clear()");
		ctrlDebug.LogInfo("Clear");

		tmTextEquation.text = "";
		tmTextEquation.Commit();

		result_Total = 0;
		result_Current = 0;
	}

	public void Plus() {
		LogCurrentResult();

		UtilLogger.LogInfo("CtrlDisplay", "Plus()");
		ctrlDebug.LogInfo("Plus");
	}

	public void Equals_BB() {
		LogCurrentResult();

		UtilLogger.LogInfo("CtrlDisplay", "Equals_BB()");
		ctrlDebug.LogInfo("Equals");

		if(!string.IsNullOrEmpty(tmTextEquation.text)) {
			result_Total += result_Current;

			tmTextEquation.text = result_Total.ToString();
			tmTextEquation.Commit();
		}
	}

	//=================
	// Helper Methods
	//=================
	private void LogCurrentResult() {
		UtilLogger.LogInfo("CtrlDisplay", "result_Total, result_Current: " + result_Total + ", " + result_Current);
	}
}
using UnityEngine;
using System.Collections;

public class CtrlDebug : Ctrl_Base {
	
	tk2dTextMesh tmDebug;

	void Start () {
		tmDebug = transform.FindChild("Text").GetComponent<tk2dTextMesh>();
	}

	public void LogInfo(string message) {
		if(tmDebug == null) {
			return;}

		if(tmDebug.text == null) {
			return;}

		tmDebug.text = message;
		tmDebug.Commit();
	}
}

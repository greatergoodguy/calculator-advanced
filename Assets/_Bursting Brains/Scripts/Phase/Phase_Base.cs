using UnityEngine;
using System.Collections;

public class Phase_Base {

	protected string numberAsString = "0";

	public string getNumberAsString() {
		return numberAsString;
	}

	public virtual void Clear(){}
	public virtual void Digit(char digit){}
	public virtual void Decimal(){}
	public virtual void Equals(){}

	public virtual void Reverse(){}
	public virtual void Plus(){}
	public virtual void Minus(){}
	public virtual void Multiply(){}
	public virtual void Divide(){}
	public virtual void Backspace(){}
}

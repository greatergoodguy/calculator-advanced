using UnityEngine;
using System.Collections;

public class DecorOperator : Decor_Base {

	Operator_BB operator_BB;
	float value;

	DecorOperator decorInner;

	public DecorOperator(Operator_BB operator_BB, float value) {
		this.operator_BB = operator_BB;
		this.value = value;
	}

	public void Equals() {

	}
}

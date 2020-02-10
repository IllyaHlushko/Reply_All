using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrLogin : MonoBehaviour {

	void OnMouseDown() {
		GameObject.Find ("Game Controller").GetComponent<scrGameController> ().StartDay ();
	}
}

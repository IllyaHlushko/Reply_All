using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrStats : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find ("Game Controller").GetComponent<scrGameController> ().ShowStats();
	}

}

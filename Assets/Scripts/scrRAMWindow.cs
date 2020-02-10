using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrRAMWindow : MonoBehaviour {
	public GameObject textDispaly;
	public Transform myRAM;

	void Start () {
		myRAM = Instantiate (textDispaly,transform).transform;
		myRAM.name = "Text Display";
		myRAM.transform.localPosition = new Vector3 (-2f, -0.45f, -0.01f);
		myRAM.GetComponent<scrTextDisplay> ().sortingLayer = "Windows";
	}

	public void DisplayRAM (string content) {
		myRAM.GetComponent<scrTextDisplay> ().DrawText (content, 2);
	}

}

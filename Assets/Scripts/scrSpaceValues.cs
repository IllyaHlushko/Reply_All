using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrSpaceValues : MonoBehaviour {
	public int currentRAM;
	public int maxRAM;
	public Transform RAM;

	void Awake () {
		maxRAM = 32;
		currentRAM = 18;
	}

	public void FindRAM () {
		RAM = GameObject.Find ("RAM Window").transform;
	}

	public void UpdateRAM() {
		if (currentRAM > maxRAM) {
			transform.GetComponent<scrGameController> ().GameOver ("OUT OF MEMORY.");
		}
		RAM.GetComponent<scrRAMWindow> ().DisplayRAM (currentRAM + "/" + maxRAM + "KB");

	}
}

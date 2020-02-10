using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrSendButton : MonoBehaviour {
	public bool needsFile;

	void OnMouseDown() {
		if (needsFile) {
			transform.parent.GetComponent<scrBigMail> ().myData.needsFile = false;
			needsFile = false;
			GameObject.Find ("Game Controller").GetComponent<scrGameController> ().Penalty ("FILE SENT", 10f);
		} else {
			GameObject.Find ("Game Controller").GetComponent<scrGameController> ().Penalty ("FILE SENT", -5f);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrSmallMail : MonoBehaviour {
	public FMail myData;
	public GameObject textDispaly;
	// Use this for initialization
	void Start () {
		SpawnText ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DeleteMe () {
		if (myData.needsFile) {
			GameObject.Find ("Game Controller").GetComponent<scrGameController> ().Penalty ("NO FILE", -5f);
		}
		transform.parent.GetComponent<scrInLook> ().RemoveMail (myData);
		transform.parent.GetComponent<scrInLook> ().ClearBigMail (myData);
		//transform.parent.GetComponent<scrInLook> ().myMails.Remove (myData);
		//transform.parent.GetComponent<scrInLook> ().RearangeMails ();
	}

	void OnMouseDown() {
		GameObject.Find ("In Look").GetComponent<scrInLook> ().OpenBigMail (myData);
	}

	void SpawnText () {
		GameObject obj = Instantiate (textDispaly);
		obj.name = "Text Display";
		obj.transform.parent = transform;

		Vector2 myDimension = new Vector2 ();
		myDimension.x = transform.localScale.x * GetComponent<SpriteRenderer> ().sprite.bounds.size.x;
		myDimension.y = transform.localScale.y * GetComponent<SpriteRenderer> ().sprite.bounds.size.y;

		Vector2 newPos = new Vector2 (- myDimension.x / 2f + 0.1f, 0f);
		obj.transform.localPosition = newPos;
		obj.GetComponent<scrTextDisplay> ().sortingLayer = "Windows";
		obj.GetComponent<scrTextDisplay> ().DrawText (myData.from, 2);
	}
}

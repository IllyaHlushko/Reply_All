using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrBigMail : MonoBehaviour {
	public FMail myData;
	public GameObject textDispaly;
	public GameObject sendButtonPF;
	public GameObject viewButtonPF;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SpawnME (FMail myMailData) {
		myData = myMailData;
		//spawning from line
		SpawnText(new Vector3(-1.1f, 2.7f, -0.01f), myData.from);

		//spawning subject line
		SpawnText(new Vector3(-1.1f, 1.8f, -0.01f), myData.subject);

		//spawnign my buttons
		if (myData.hasFile) {
			GameObject myViewButton = Instantiate (viewButtonPF);
			myViewButton.transform.parent = transform;
			myViewButton.transform.localPosition = new Vector3 (-1.9f, -2.7f, -0.01f);
			myViewButton.GetComponent<scrViewButton> ().virus = myData.virus;
			myViewButton.GetComponent<scrViewButton> ().file = myData.myFile;
		}
		GameObject myStartButton = Instantiate (sendButtonPF);
		myStartButton.transform.parent = transform;
		myStartButton.transform.localPosition = new Vector3 (1.8f, -2.7f, -0.01f);
		myStartButton.GetComponent<scrSendButton> ().needsFile = myMailData.needsFile;

		//spawning content of the mail
		transform.GetComponent<scrTextFile> ().SpawnTextWindow (new Vector3(-2.9f, 0.9f, -0.01f), myData.content); 
	}

	public void SpawnText (Vector3 location, string content) {
		GameObject obj = Instantiate (textDispaly);
		obj.name = "Text Display";
		obj.transform.parent = transform;

		obj.transform.localPosition = location;
		obj.GetComponent<scrTextDisplay> ().sortingLayer = "Windows";
		obj.GetComponent<scrTextDisplay> ().DrawText (content, 2);
	}
}

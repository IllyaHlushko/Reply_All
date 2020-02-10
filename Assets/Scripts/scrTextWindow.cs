using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrTextWindow : MonoBehaviour {
	public GameObject textDispaly;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.T)) {
			DisplayText (new string[] {"Test 1", "TEST 2", "A GIANT MASSIVE TEST 3"});
		}
	}

	public void DisplayText (string[] content) {
		//first row is the title
		for (int i = 0; i < content.Length; i++) {
			SpawnText (content[i], new Vector3 (0f, - 0.9f * i, -0.01f));
		}
	}

	void SpawnText (string myText, Vector3 position) {
		GameObject obj = Instantiate (textDispaly);
		obj.name = "Text Display";
		obj.transform.parent = transform;
		obj.transform.localPosition = position;
		obj.GetComponent<scrTextDisplay> ().sortingLayer = "Windows";
		obj.GetComponent<scrTextDisplay> ().DrawText (myText, transform.parent.GetComponent<SpriteRenderer> ().sortingOrder + 1);
	}
}

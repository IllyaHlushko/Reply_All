using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrPenaltyBar : MonoBehaviour {
	public GameObject textDispaly;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DispalyPenalty (string title, string content) {
		SpawnText (title, new Vector3 (-3.9f, 0.45f, -0.01f));
		SpawnText (content, new Vector3 (-3.9f, -0.45f, -0.01f));
	}

	void SpawnText (string myText, Vector3 position) {
		GameObject obj = Instantiate (textDispaly);
		obj.name = "Text Display";
		obj.transform.parent = transform;

		obj.transform.localPosition = position;
		obj.GetComponent<scrTextDisplay> ().sortingLayer = "Windows";
		obj.GetComponent<scrTextDisplay> ().DrawText (myText, GetComponent<SpriteRenderer>().sortingOrder + 1);
	}
}

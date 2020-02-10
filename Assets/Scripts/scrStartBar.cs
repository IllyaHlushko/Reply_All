using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrStartBar : MonoBehaviour {
	public GameObject clock;

	// Use this for initialization
	void Awake () {
		//geting sprite dimensions
		Vector2 spriteDimension = new Vector2 ();
		spriteDimension.x = transform.localScale.x * GetComponent<SpriteRenderer> ().sprite.bounds.size.x;
		spriteDimension.y = transform.localScale.y * GetComponent<SpriteRenderer> ().sprite.bounds.size.y;

		Vector2 newPos = Camera.main.ScreenToWorldPoint(new Vector2 (Screen.width / 2f, 0f));
		newPos += Vector2.up * spriteDimension.y / 2f;
		transform.position = newPos;

		SpawnClock ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SpawnClock () {
		GameObject obj = Instantiate (clock);
		obj.name = "Clock Display";
		Vector2 newPos = Camera.main.ScreenToWorldPoint(new Vector2 (Screen.width, 0f));
		newPos += Vector2.left * 1.8f + Vector2.up * 0.35f;
		obj.transform.position = newPos;
		obj.transform.GetComponent<scrTextDisplay> ().sortingLayer = "Icons";
	}
}

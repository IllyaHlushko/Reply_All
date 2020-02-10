using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrOffButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector2 myDimension = new Vector2 ();
		myDimension.x = transform.localScale.x * GetComponent<SpriteRenderer>().sprite.bounds.size.x;  // this is gonna be our width
		myDimension.y = transform.localScale.y * GetComponent<SpriteRenderer>().sprite.bounds.size.y;  // this is gonna be our height

		//tmpDimension *= 10f;

		Vector2 bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2(0f, 0f));
		bottomLeft += new Vector2 (myDimension.x / 2f + 0.1f, myDimension.y / 2f + 0.1f);

		transform.position = bottomLeft;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown () {
		GameObject.Find ("Game Controller").GetComponent<scrGameController> ().TurnOff ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrInLookIcon : MonoBehaviour {

	void Start () {
		Vector2 myDimension = new Vector2 ();
		myDimension.x = transform.localScale.x * GetComponent<SpriteRenderer>().sprite.bounds.size.x;  // this is gonna be our width
		myDimension.y = transform.localScale.y * GetComponent<SpriteRenderer>().sprite.bounds.size.y;  // this is gonna be our height

		//tmpDimension *= 10f;

		Vector2 topLeft = Camera.main.ScreenToWorldPoint(new Vector2(0f, Screen.height));
		topLeft += new Vector2 (myDimension.x / 2f + 0.1f, -myDimension.y / 2f - 0.1f);

		transform.position = topLeft;
	}

	void OnMouseDown() {
		if (GameObject.Find ("In Look").transform.position.y > 50f) {
			GameObject.Find ("In Look").transform.position += Vector3.down * 100f;
		}
	}
}

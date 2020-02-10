using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrListFile : MonoBehaviour {
	public string[] list;
	// Use this for initialization
	void Start () {
		Vector2 myDimension = new Vector2 ();
		myDimension.x = transform.localScale.x * GetComponent<SpriteRenderer>().sprite.bounds.size.x;  // this is gonna be our width
		myDimension.y = transform.localScale.y * GetComponent<SpriteRenderer>().sprite.bounds.size.y;  // this is gonna be our height

		//tmpDimension *= 10f;

		Vector2 topLeft = Camera.main.ScreenToWorldPoint(new Vector2(0f, Screen.height));
		topLeft += new Vector2 (myDimension.x / 2f + 0.1f, -myDimension.y / 2f - 0.5f -myDimension.y);

		transform.position = topLeft;

		transform.GetComponent<scrViewButton> ().file = list;// new string[] {"ACCESS LIST", "LVL NAME", "3   BOB", "2   JEFF", "2   ALEX" , "5   MIKE C."};
	}
}

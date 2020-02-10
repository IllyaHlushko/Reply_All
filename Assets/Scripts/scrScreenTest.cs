using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrScreenTest : MonoBehaviour {
	public float screenWidth;
	public float screenHeight;
	public Vector2 mousePosition;
	public GameObject Icon;
	public Vector2 tmpDimension;
	// Use this for initialization
	void Start () {
		screenWidth = Screen.width;
		screenHeight = Screen.height;

		tmpDimension = new Vector2 ();
		tmpDimension.x = Icon.transform.localScale.x * Icon.GetComponent<SpriteRenderer>().sprite.bounds.size.x;  // this is gonna be our width
		tmpDimension.y = Icon.transform.localScale.y * Icon.GetComponent<SpriteRenderer>().sprite.bounds.size.y;  // this is gonna be our height

		//tmpDimension *= 10f;

		Vector2 topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height) - tmpDimension);
		topRight -= tmpDimension/2f;
		Vector2 bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2 (0f, 0f));
		bottomLeft += tmpDimension/2f;
		Instantiate (Icon, topRight, transform.rotation);
		Instantiate (Icon, bottomLeft, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		screenWidth = Screen.width;
		screenHeight = Screen.height;
		mousePosition = Input.mousePosition;
	}
}

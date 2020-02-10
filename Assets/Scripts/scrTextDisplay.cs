using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrTextDisplay : MonoBehaviour {
	public Sprite[] numbers = new Sprite[11];
	public Vector2 nextPosition;
	public string sortingLayer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DrawText(string text, int sortingOrder) {
		//Debug.Log ("Drawn");
		nextPosition = new Vector2();
		ClearText ();
		//setting up a big parent to get rid of the line
		GameObject parentObj = new GameObject();
		parentObj.transform.parent = transform;
		parentObj.transform.localPosition = Vector2.zero;
		for (int i = 0; i < text.Length; i++) {
			//Debug.Log (text [i]);
			GameObject myObj = new GameObject();
			myObj.AddComponent<SpriteRenderer> ();

			//choosing the sprite
			//myObj.GetComponent<SpriteRenderer> ().sprite = numbers [0];
			switch (text [i]) {
			case '0':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [0];
				break;
			case '1':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [1];
				break;
			case '2':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [2];
				break;
			case '3':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [3];
				break;
			case '4':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [4];
				break;
			case '5':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [5];
				break;
			case '6':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [6];
				break;
			case '7':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [7];
				break;
			case '8':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [8];
				break;
			case '9':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [9];
				break;
			case ':':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [10];
				break;
			case 'A':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [11];
				break;
			case 'B':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [12];
				break;
			case 'C':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [13];
				break;
			case 'D':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [14];
				break;
			case 'E':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [15];
				break;
			case 'F':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [16];
				break;
			case 'G':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [17];
				break;
			case 'H':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [18];
				break;
			case 'I':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [19];
				break;
			case 'J':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [20];
				break;
			case 'K':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [21];
				break;
			case 'L':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [22];
				break;
			case 'M':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [23];
				break;
			case 'N':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [24];
				break;
			case 'O':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [25];
				break;
			case 'P':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [26];
				break;
			case 'Q':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [27];
				break;
			case 'R':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [28];
				break;
			case 'S':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [29];
				break;
			case 'T':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [30];
				break;
			case 'U':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [31];
				break;
			case 'V':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [32];
				break;
			case 'W':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [33];
				break;
			case 'X':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [34];
				break;
			case 'Y':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [35];
				break;
			case 'Z':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [36];
				break;
			case ' ':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [37];
				break;
			case '?':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [38];
				break;
			case '!':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [39];
				break;
			case '=':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [40];
				break;
			case '.':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [41];
				break;
			case '(':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [42];
				break;
			case ')':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [43];
				break;
			case '/':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [44];
				break;
			case '$':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [45];
				break;
			case '+':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [46];
				break;
			case '-':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [47];
				break;
			case '*':
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [48];
				break;
			default:
				myObj.GetComponent<SpriteRenderer> ().sprite = numbers [48];
				break;
			}

			myObj.GetComponent<SpriteRenderer> ().sortingLayerName = sortingLayer;
			myObj.transform.parent = parentObj.transform;
			myObj.GetComponent<SpriteRenderer> ().sortingOrder = sortingOrder;//

			//geting sprite dimensions
			Vector2 spriteDimension = new Vector2 ();
			spriteDimension.x = myObj.transform.localScale.x * myObj.GetComponent<SpriteRenderer> ().sprite.bounds.size.x;
			spriteDimension.y = 0;

			//Debug.Log (spriteDimension);

			nextPosition += spriteDimension / 2f;
			myObj.transform.localPosition = nextPosition;
			nextPosition += spriteDimension / 2f + Vector2.left * -0.1f;
		}
		//Debug.Log (num0.transform.GetComponent<SpriteRenderer> ().sprite.bounds.size.x );
	}

	public void ClearText() {
		if (transform.childCount > 0) {
			//Debug.Log ("Cleared");
			Destroy (transform.GetChild (0).gameObject);
			nextPosition = new Vector2();
		}
	}
}

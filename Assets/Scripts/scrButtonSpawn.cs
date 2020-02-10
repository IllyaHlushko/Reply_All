using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrButtonSpawn : MonoBehaviour {
	public GameObject button;
	public bool dontClose;
	public Vector2 offset;
	// Use this for initialization
	void Start () {
		//create a close button
		//geting my dimensions
		Vector2 myDimension = new Vector2 ();
		myDimension.x = transform.localScale.x * GetComponent<SpriteRenderer> ().sprite.bounds.size.x;
		myDimension.y = transform.localScale.y * GetComponent<SpriteRenderer> ().sprite.bounds.size.y;

		//geting button dimensions
		Vector2 buttonDimension = new Vector2 ();
		buttonDimension.x = button.transform.localScale.x * button.GetComponent<SpriteRenderer> ().sprite.bounds.size.x;
		buttonDimension.y = button.transform.localScale.y * button.GetComponent<SpriteRenderer> ().sprite.bounds.size.y;

		GameObject obj = Instantiate (button);
		obj.transform.parent = transform;
		obj.transform.localPosition = myDimension / 2f - buttonDimension / 2f - offset;
		obj.transform.localPosition -= Vector3.forward / 10f;
		obj.GetComponent<SpriteRenderer> ().sortingOrder = transform.GetComponent<SpriteRenderer>().sortingOrder + 1;
		if (dontClose) {
			obj.GetComponent<scrCloseButton> ().close = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

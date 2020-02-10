using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrAdWindow : MonoBehaviour {
	public GameObject closeButton;
	//public GameObject fakes;
	public Color myC;
	// Use this for initialization
	void Start () {
		//create a close button
		//geting ad dimensions

		Vector2 adDimension = new Vector2 ();
		adDimension.x = transform.localScale.x * GetComponent<SpriteRenderer> ().sprite.bounds.size.x;
		adDimension.y = transform.localScale.y * GetComponent<SpriteRenderer> ().sprite.bounds.size.y;

		//geting ad dimensions
		Vector2 buttonDimension = new Vector2 ();
		buttonDimension.x = closeButton.transform.localScale.x * closeButton.GetComponent<SpriteRenderer> ().sprite.bounds.size.x;
		buttonDimension.y = closeButton.transform.localScale.y * closeButton.GetComponent<SpriteRenderer> ().sprite.bounds.size.y;

		GameObject obj = Instantiate (closeButton);
		obj.transform.parent = transform;
		obj.transform.localPosition = adDimension / 2f - buttonDimension / 2f;
		obj.transform.localPosition -= Vector3.forward / 10f;
		if (Random.value < 0.5f) {
			//Debug.Log ("Inverted X");
			obj.transform.localPosition = new Vector3 (-obj.transform.localPosition.x, obj.transform.localPosition.y, obj.transform.localPosition.z);
		}

		if (Random.value < 0.5f) {
			//Debug.Log ("Inverted Y");
			obj.transform.localPosition = new Vector3 (obj.transform.localPosition.x, -obj.transform.localPosition.y, obj.transform.localPosition.z);
		}

		obj.GetComponent<SpriteRenderer> ().sortingOrder = (int)((Time.timeSinceLevelLoad * 10f)+1f);
		myC = new Color (Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f));
		transform.GetComponent<SpriteRenderer> ().color = myC;

		/*
		GameObject myFakes = Instantiate (fakes,transform);
		myFakes.transform.localPosition = Vector3.zero;
		fakes.GetComponent<SpriteRenderer> ().sortingLayerName = transform.GetComponent<SpriteRenderer> ().sortingLayerName;
		fakes.GetComponent<SpriteRenderer> ().sortingOrder = transform.GetComponent<SpriteRenderer> ().sortingOrder;
		*/

		//Creating the base window

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

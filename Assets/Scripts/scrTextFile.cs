using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrTextFile : MonoBehaviour {
	public GameObject textWindowPF;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DispalyContent (string[] content) {
		//calculate the boundaries
		//geting ad dimensions
		Vector2 myDimension = new Vector2 ();
		myDimension.x = transform.localScale.x * GetComponent<SpriteRenderer> ().sprite.bounds.size.x;
		myDimension.y = transform.localScale.y * GetComponent<SpriteRenderer> ().sprite.bounds.size.y;

		//calculating the furthest bottom left poin the ad can spawn in
		Vector3 position = new Vector3( -myDimension.x / 2f + 0.1f, myDimension.y / 2f - 0.45f, -0.01f);

		SpawnTextWindow (position, content);
	}

	public void SpawnTextWindow (Vector3 position, string[] content) {
		GameObject myWindow = Instantiate (textWindowPF);
		myWindow.transform.parent = transform;
		myWindow.transform.localPosition = position;
		myWindow.GetComponent<scrTextWindow> ().DisplayText (content);
	}
}

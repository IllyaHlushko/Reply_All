using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrDeleteButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {
		transform.parent.GetComponent<scrSmallMail> ().DeleteMe ();
		Destroy (transform.parent.gameObject);
	}
}

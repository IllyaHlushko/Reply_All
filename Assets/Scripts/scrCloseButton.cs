using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrCloseButton : MonoBehaviour {
	public bool close;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown() {
		if (close) {
			//ads get destroyed
			GameObject.Find("Game Controller").transform.GetComponent<scrSpaceValues> ().currentRAM -= 2;
			Destroy (transform.parent.gameObject);
		} else {
			//special windows need remain active
			transform.parent.position += Vector3.up * 100f;
		}
	}

}

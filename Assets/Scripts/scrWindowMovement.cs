using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrWindowMovement : MonoBehaviour {
	public bool followMouse;
	public Vector2 offSet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (followMouse) {
			Vector2 targetPosition = (Vector2)Camera.main.ScreenToWorldPoint(new Vector2 (Input.mousePosition.x, Input.mousePosition.y)) + offSet;
			transform.position = new Vector3(targetPosition.x, targetPosition.y, transform.position.z);
		}
	}

	void OnMouseDown() {
		followMouse = true;
		offSet = new Vector2(transform.position.x, transform.position.y) - (Vector2)Camera.main.ScreenToWorldPoint(new Vector2 (Input.mousePosition.x, Input.mousePosition.y));
	}

	void OnMouseUp() {
		followMouse = false;
	}
}

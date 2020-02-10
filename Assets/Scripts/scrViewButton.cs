using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrViewButton : MonoBehaviour {
	public string[] file;
	public bool virus;


	void OnMouseDown() {
		//Debug.Log ("Clicked view");
		if (virus) {
			StartCoroutine(GameObject.Find ("Game Controller").GetComponent<scrAdSpawner> ().SpawnAd (0f, Random.Range(1,5), Random.Range(0.1f,0.5f)));
			GameObject.Find("Game Controller").transform.GetComponent<scrSpaceValues> ().currentRAM += 2;
			GameObject.Find ("Game Controller").GetComponent<scrGameController> ().OpenTextFile (file);
		} else {
			GameObject.Find("Game Controller").transform.GetComponent<scrSpaceValues> ().currentRAM += 2;
			GameObject.Find ("Game Controller").GetComponent<scrGameController> ().OpenTextFile (file);
		}
	}

}

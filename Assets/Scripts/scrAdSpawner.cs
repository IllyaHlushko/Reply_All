using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrAdSpawner : MonoBehaviour {
	public GameObject adWindow;
	// Use this for initialization
	void Start () {
		//StartCoroutine (SpawnAd (0.2f, 20, spawnDelay));
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.S)) {
			StopAllCoroutines ();
		}
	}

	public IEnumerator SpawnAd(float delayTime, int repeat, float repeatDelayTime) {
		//wait for the time the ad is meant to show up
		yield return new WaitForSeconds (delayTime);

		//show the ad

		//calculate the boundaries
		//geting ad dimensions
		Vector2 adDimension = new Vector2 ();
		adDimension.x = adWindow.transform.localScale.x * adWindow.GetComponent<SpriteRenderer> ().sprite.bounds.size.x;
		adDimension.y = adWindow.transform.localScale.y * adWindow.GetComponent<SpriteRenderer> ().sprite.bounds.size.y;

		//calculating the furthest top right poin the ad can spawn in
		Vector2 topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height) - adDimension);
		topRight -= adDimension/2f;

		//calculating the furthest bottom left poin the ad can spawn in
		Vector2 bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2 (0f, 0f));
		bottomLeft += adDimension/2f;

		//ad z location is based on the time passed, so that the new adds that show up have to be closed because they will be on top of other things
		GameObject obj = Instantiate(adWindow, new Vector3(Random.Range(bottomLeft.x,topRight.x), Random.Range(bottomLeft.y,topRight.y), - Time.timeSinceLevelLoad), transform.rotation);
		obj.GetComponent<SpriteRenderer> ().sortingOrder = (int)(Time.timeSinceLevelLoad * 10f);

		//add the memory value of the ad to the RAM
		GetComponent<scrSpaceValues> ().currentRAM += 2;

		if (repeat > 0) {
			repeat--;
			StartCoroutine (SpawnAd (repeatDelayTime, repeat, repeatDelayTime));
		}
	}
}

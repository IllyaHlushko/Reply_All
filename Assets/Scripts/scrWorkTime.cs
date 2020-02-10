using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrWorkTime : MonoBehaviour {
	public float endTime;
	public float currentTime;
	public int secondsPerHour;

	public int hours;
	public int minutes;

	public Transform clock;

	public void FindClock () {
		clock = GameObject.Find ("Clock Display").transform;
	}

	public void UpdateClock () {
		currentTime = Time.timeSinceLevelLoad;
		if (currentTime > 8f * secondsPerHour) {
			GameObject.Find ("Game Controller").GetComponent<scrGameController> ().LevelComplete ();
		}
		hours = 9 + (int)(currentTime / secondsPerHour);
		minutes = 0 + (int)((currentTime % secondsPerHour)*(60f / secondsPerHour));
		string myString = "";
		if (hours < 10) {
			myString += "0" + hours;
		} else {
			myString += hours;
		}
		myString += ":";
		if (minutes < 10) {
			myString += "0" + minutes;
		} else {
			myString += minutes;
		}

		clock.GetComponent<scrTextDisplay> ().DrawText (myString, 2);
	}

}

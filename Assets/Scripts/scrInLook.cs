using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class scrInLook : MonoBehaviour {
	public List<FMail> myMails = new List<FMail> ();
	public GameObject bigMailPF;
	public GameObject myBigMail;
	public GameObject textDisplayPF;
	public Transform myMailCount;
	// Use this for initialization
	void Start () {
		//myMails = GameObject.Find ("Game Controller").GetComponent<scrGameController> ().myMails;
		myMailCount = Instantiate(textDisplayPF,transform).transform;
		myMailCount.localPosition = new Vector3 (-4.9f, 2.25f, -0.01f);
	}
	
	// Update is called once per frame
	void Update () {
		
		string mailCount;
		mailCount = "(" + myMails.Count + "/5)";
		myMailCount.GetComponent<scrTextDisplay> ().sortingLayer = "Windows";
		myMailCount.GetComponent<scrTextDisplay> ().DrawText (mailCount, 1);
		if (myMails.Count > 5) {
			GameObject.Find ("Game Controller").GetComponent<scrGameController> ().GameOver ("INBOX FULL");
		}
	}

	public void RemoveMail (FMail mail) {
		myMails.Remove (mail);
		StartCoroutine (delayedRearange());
		//RearangeMails ();
	}

	public void RearangeMails () {
		for (int i = myMails.Count; i > 0; i--) {
			Debug.Log (i);
			Debug.Log ("Got "+ transform.GetChild (i).name + " Which is number " + i + 1);
			transform.GetChild (i + 1).localPosition = new Vector3 (-3f, 2.25f - 0.9f * i, -0.01f);
			Debug.Log ("Moved to " + new Vector3 (-3f, 2.25f - 0.9f * i, -0.01f));
		}
	}

	//make-shift solution, deleting an element and rearanging children at the same time doesn't work
	public IEnumerator delayedRearange () {
		yield return new WaitForSeconds (0f);
		RearangeMails ();
	}

	public void OpenBigMail (FMail mailData) {
		if (myBigMail != null) {
			ClearBigMail (myBigMail.GetComponent<scrBigMail>().myData);
		}

		myBigMail = Instantiate (bigMailPF);
		myBigMail.transform.parent = transform;
		myBigMail.transform.localPosition = new Vector3 (2f, -0.45f, -0.01f);
		myBigMail.GetComponent<scrBigMail> ().SpawnME (mailData);
	}

	public void ClearBigMail (FMail mailTest) {
		if (myBigMail != null) {
			if (myBigMail.GetComponent<scrBigMail>().myData == mailTest) {
				Destroy (myBigMail);
			}
		}
	}

}

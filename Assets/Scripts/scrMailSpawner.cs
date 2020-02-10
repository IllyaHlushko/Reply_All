using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrMailSpawner : MonoBehaviour {
	public GameObject smallMail;
	public float spawnDelay;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

	public IEnumerator SpawnMail(FMail myMail) {
		//wait for the time the ad is meant to show up
		yield return new WaitForSeconds (myMail.spawnDelay);

		//calculate the boundaries
		//geting mail dimensions
		Vector2 mailDimension = new Vector2 ();
		mailDimension.x = smallMail.transform.localScale.x * smallMail.GetComponent<SpriteRenderer> ().sprite.bounds.size.x;
		mailDimension.y = smallMail.transform.localScale.y * smallMail.GetComponent<SpriteRenderer> ().sprite.bounds.size.y;

		GameObject obj = Instantiate(smallMail);
		obj.transform.parent = GameObject.Find ("In Look").transform;
		GameObject.Find ("In Look").transform.GetComponent<scrInLook> ().myMails.Add (myMail);
		obj.transform.localPosition = new Vector3 (-3f, 2.25f - 0.9f * GameObject.Find ("In Look").transform.GetComponent<scrInLook> ().myMails.Count, -0.01f);
		obj.GetComponent<scrSmallMail> ().myData = myMail;

		//add it to the mail list

		//add the memory value of the ad to the RAM
		//GetComponent<scrSpaceValues> ().currentRAM += 1f;
	}

	//workaround
	public void MailToSpawn (FMail myMail) {
		StartCoroutine(SpawnMail (myMail));
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class scrGameController : MonoBehaviour {
	public float curentTime;
	public float currentMoney;
	public string reason;
	public int day;
	public GameObject penaltyBarPF;
	public GameObject textFilePF;
	public List<FMail> myMails1 = new List<FMail> ();
	public List<FMail> myMails2 = new List<FMail> ();
	public List<FAd> myAds1 = new List<FAd> ();
	public List<FAd> myAds2 = new List<FAd> ();


	//making game controller persistent
	private static bool created = false;
	void Awake()
	{
		
		if (!created)
		{
			//creating days
			SaveDaysWeb ();
			Debug.Log ("Saved");

			//persistence
			DontDestroyOnLoad(this.gameObject);
			created = true;
			//Debug.Log("Awake: " + this.gameObject);
		}
	}
	// gettign scene stuff
	void OnEnable()
	{
		SaveDaysWeb ();
		//Debug.Log("OnEnable called");
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		SaveDaysWeb ();
		if ((SceneManager.GetActiveScene ().name != "Login")&&(SceneManager.GetActiveScene ().name != "In Between")&&(SceneManager.GetActiveScene ().name != "Game Over")) {
			transform.GetComponent<scrSpaceValues> ().FindRAM ();
			transform.GetComponent<scrWorkTime> ().FindClock ();Debug.Log ("Started");
			//loading mails
			List<FMail> dailyMails = LoadDayMails ();
			foreach (FMail mail in dailyMails) {
				GetComponent<scrMailSpawner> ().MailToSpawn (mail);
				Debug.Log ("Loaded 1 mail");
			}
			Debug.Log ("Loaded mails");
			//loading ads
			List<FAd> dailyAds = LoadDayAds ();
			foreach (FAd ad in dailyAds) {
				StartCoroutine(GetComponent<scrAdSpawner> ().SpawnAd (ad.delayTime, ad.repeat, ad.repeatDelayTime));
				Debug.Log ("Loaded 1 ad");
			}
			Debug.Log ("Loaded ads");
		}
		if (SceneManager.GetActiveScene ().name == "Login") {
			currentMoney = 0;
		}

		//Debug.Log("OnSceneLoaded: " + scene.name);
		//Debug.Log(mode);
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			TurnOff();
		}

		curentTime = Time.timeSinceLevelLoad;
		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}

		if (Input.GetKeyDown (KeyCode.L)) {
			/*
			List<FMail> dailyMails = LoadDay ();
			foreach (FMail mail in dailyMails) {
				GetComponent<scrMailSpawner> ().MailToSpawn (mail);
				Debug.Log ("Loaded 1 mail");
			}
			Debug.Log ("Loaded");
			*/
		}

		//Updating RAM
		if ((SceneManager.GetActiveScene ().name != "Login")&&(SceneManager.GetActiveScene ().name != "In Between")&&(SceneManager.GetActiveScene ().name != "Game Over")) {
			transform.GetComponent<scrSpaceValues> ().UpdateRAM ();
			transform.GetComponent<scrWorkTime> ().UpdateClock ();
		}
	}

	/*
	List<FMail> LoadDayMails() {
		if (File.Exists (Application.dataPath + "/Day_" + day + "_Mails.sav")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream stream = new FileStream (Application.dataPath + "/Day_" + day + "_Mails.sav", FileMode.Open);
			List<FMail> theMails = bf.Deserialize (stream) as List<FMail>;
			stream.Close ();
			return theMails;
		} else {
			Debug.LogError ("File doesn't exist " + day);
			return new List<FMail> ();
		}
	}*/

	//web
	List<FMail> LoadDayMails() {
		if (day == 1) {
			return myMails1;
		} else {
			return myMails2;
		}
	}

	/*
	List<FAd> LoadDayAds() {
		if (File.Exists (Application.dataPath + "/Day_" + day + "_Ads.sav")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream stream = new FileStream (Application.dataPath + "/Day_" + day + "_Ads.sav", FileMode.Open);
			List<FAd> theAds = bf.Deserialize (stream) as List<FAd>;
			stream.Close ();
			return theAds;
		} else {
			Debug.LogError ("File doesn't exist " + day);
			return new List<FAd> ();
		}
	}*/

	//web
	List<FAd> LoadDayAds() {
		if (day == 1) {
			return myAds1;
		} else {
			return myAds2;
		}
	}

	/*
	void SaveProgress() {
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream stream = new FileStream (Application.dataPath + "/Save.sav", FileMode.Create);

		bf.Serialize (stream, myMails);
		stream.Close ();
	}

	void LoadProgress() {
		if (File.Exists (Application.dataPath + "/Save.sav")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream stream = new FileStream (Application.dataPath + "/Save.sav", FileMode.Open);
			List<FMail> theMails = bf.Deserialize (stream) as List<FMail>;
			stream.Close ();
			//return theMails;
		} else {
			Debug.LogError ("File doesn't exist");
			//return new List<FMail> ();
		}
	}
	*/

	public void Penalty (string reason, float amount) {
		currentMoney += amount;
		//calculate the boundaries
		//geting ad dimensions
		Vector2 myDimension = new Vector2 ();
		myDimension.x = penaltyBarPF.transform.localScale.x * penaltyBarPF.GetComponent<SpriteRenderer> ().sprite.bounds.size.x;
		myDimension.y = penaltyBarPF.transform.localScale.y * penaltyBarPF.GetComponent<SpriteRenderer> ().sprite.bounds.size.y;

		//calculating the furthest bottom left poin the ad can spawn in
		Vector2 bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2 (0f, 0f));
		bottomLeft += myDimension/2f + Vector2.up * 0.9f + Vector2.left * - 0.2f;

		//ad z location is based on the time passed, so that the new adds that show up have to be closed because they will be on top of other things
		GameObject obj = Instantiate(penaltyBarPF, new Vector3 (bottomLeft.x, bottomLeft.y, - Time.timeSinceLevelLoad), transform.rotation);
		obj.GetComponent<SpriteRenderer> ().sortingOrder = (int) Time.timeSinceLevelLoad;
		string title;
		if (amount > 0f) {
			title = "REWARD!";
		} else {
			title = "PENALTY!";
		}

		string content = reason + " ";

		content += amount + "$";


		obj.GetComponent<scrPenaltyBar> ().DispalyPenalty (title, content);
		GetComponent<scrSpaceValues> ().currentRAM += 2;

	}

	public void StartDay() {
		if (SceneManager.GetActiveScene ().name == "Game Over") {
			SceneManager.LoadScene ("Login");
			day = 0;
		} else {
			Debug.Log ("Day " + day);
			day++;
			Debug.Log ("Day " + day);
			if (day < 3) {
				SceneManager.LoadScene ("Day " + day);
			} else {
				SceneManager.LoadScene ("Login");
				day = 0;
			}
		}
	}

	public void GameOver (string reasonL) {
		Debug.Log (reason);
		reason = reasonL;
		SceneManager.LoadScene("Game Over");
		StopAllCoroutines ();
		GetComponent<scrAdSpawner> ().StopAllCoroutines ();
		GetComponent<scrMailSpawner> ().StopAllCoroutines ();
		transform.GetComponent<scrSpaceValues> ().currentRAM = 18;
	}

	public void LevelComplete () {
		//get the outstanding mails
		//get whatever data you need
		//save progress
		//move on to the intermision level
		SceneManager.LoadScene("In Between");
		Debug.Log("Level Complete");
		StopAllCoroutines ();
		GetComponent<scrAdSpawner> ().StopAllCoroutines ();
		GetComponent<scrMailSpawner> ().StopAllCoroutines ();
		transform.GetComponent<scrSpaceValues> ().currentRAM = 18;
	}

	public void ShowStats () {
		if (SceneManager.GetActiveScene ().name == "Game Over") {
			OpenTextFile (new string[] { "STATS", "MONEY: " + currentMoney + "$", "RENT: 100$", "DAY " + day + "/2" , "", "GAME OVER", "" + reason});
		} else {
			if (day < 2) {
				OpenTextFile (new string[] { "STATS", "MONEY: " + currentMoney + "$", "RENT: 100$", "DAY " + day + "/2" });
			} else {
				if (currentMoney < 100) {
					OpenTextFile (new string[] { "STATS", "MONEY: " + currentMoney + "$", "RENT: 100$", "DAY " + day + "/2","", "PROBATION", "COMPLETE", "", "RENT NOT PAID"});
				} else {
					OpenTextFile (new string[] { "STATS", "MONEY: " + currentMoney + "$", "RENT: 100$", "DAY " + day + "/2", "", "PROBATION", "COMPLETE", "", "RENT PAID"});
				}
			}
		}
	}

	public void OpenTextFile (string[] file) {
		//calculate the boundaries
		//geting ad dimensions
		Vector2 myDimension = new Vector2 ();
		myDimension.x = textFilePF.transform.localScale.x * textFilePF.GetComponent<SpriteRenderer> ().sprite.bounds.size.x;
		myDimension.y = textFilePF.transform.localScale.y * textFilePF.GetComponent<SpriteRenderer> ().sprite.bounds.size.y;

		//calculating the furthest bottom left poin the ad can spawn in
		Vector2 topLeft = Camera.main.ScreenToWorldPoint(new Vector2 (0f, Screen.height));
		topLeft += new Vector2 (myDimension.x / 2f, -myDimension.y / 2f)  - Vector2.up * 0.1f + Vector2.left * - 0.1f;

		//ad z location is based on the time passed, so that the new adds that show up have to be closed because they will be on top of other things
		GameObject obj = Instantiate(textFilePF, new Vector3 (topLeft.x, topLeft.y, - Time.timeSinceLevelLoad), transform.rotation);
		obj.GetComponent<SpriteRenderer> ().sortingOrder = (int) Time.timeSinceLevelLoad;
		obj.GetComponent<scrTextFile> ().DispalyContent (file);
	}

	public void TurnOff () {
		Application.Quit ();

	}

	/*
	void SaveDays() {
		//mail template 
		//day1Mails.Add (new FMail (f,"",	"", new string[] {"", "", "", ""},	true, true,	false, new string[]{"", "", "", "", "", "", "", "", ""}));
		//***************************************************************** big setup for all of the days *******************************************************************
		BinaryFormatter bf = new BinaryFormatter ();
		//-------------------------------------------------------------------- Day 1 --------------------------------------------------------------
		FileStream streamM1 = new FileStream (Application.dataPath + "/Day_1_Mails.sav", FileMode.Create);

		List<FMail> day1Mails = new List<FMail> ();
		day1Mails.Add (new FMail (1f,	"BOSS",	"INFO 1",	 new string[] {"HI.WELCOME", "TO THE JOB.", "READ FILE", "PLEASE"},	false,	true,	false,	new string[]{"INSTRUCTIONS", "YOUR JOB IS TO", "SEND FILES TO", "PEOPLE WHO", "NEED THEM.", "YOU WORK FROM", "09:00 TO 17:00.", "NO BREAKS!"}));
		day1Mails.Add (new FMail (15f,	"BOSS",	"INFO 2",	 new string[] {"FOLLOW UP", "READ FILE", "SEND ME:", "F5"},	true,	true,	false,	new string[]{"INSTRUCTIONS", "PRESS SEND", "TO SEND FILE.", "DO NOT SEND", "FILES UNLESS", "PEOPLE ASKED", "YOU TO. ONLY", "SEND ONE FILE."}));
		day1Mails.Add (new FMail (30f,	"BOSS",	"INFO 3",	 new string[] {"FOLLOW UP", "", "READ FILE", "PLEASE"},	false,	true,	false,	new string[]{"INSTRUCTIONS", "IF YOU SEND", "FILE CORRECTLY", "YOU GET PAID.", "OTHERWISE YOU", "GET A PENALTY.", "IF DO NOT SEND", "WHEN ASKED YOU", "GET A PENALTY."}));
		day1Mails.Add (new FMail (45f,	"BOSS",	"INFO 4",	 new string[] {"FOLLOW UP", "", "READ FILE", "PLEASE"},	false,	true,	false,	new string[]{"INSTRUCTIONS", "INBOX SIZE IS", "LIMITED.", "", "PLEASE KEEP", "YOUR INBOX", "EMPTY OR YOU", "WILL BE FIRED."}));
		day1Mails.Add (new FMail (60f,	"IT",	"PC",	 new string[] {"HI. PLEASE", "READ PC", "USE RULES", "SEND F1"},	true,	true,	false,	new string[]{"PC USE RULES", "YOU HAVE YOUR", "ICONS ON THE", "LEFT IN ORDER:", "1.INLOOK.", "2.ACCESS LIST.", "3.RAM STATUS.", ""}));
		day1Mails.Add (new FMail (75f,	"IT",	"PC",	 new string[] {"FOLLOW UP.", "", "", "READ FILE"},	false,	true,	false,	new string[]{"PC USE RULES", "YOU CAN MOVE", "WINDOWS AROUND", "ON YOUR SCREEN", "THE SPACE IS", "LIMITED SO JUST", "KEEP IT TIDY.", "", "GOOD LUCK :)"}));
		day1Mails.Add (new FMail (90f,	"IT",	"MAIL",	 new string[] {"HI.JUST", "A REMINDER", "PLEASE DO", "NOT REPLY"},	false,	true,	false,	new string[]{"NO REPLY ALL", "I AM TALKING", "TO YOU BOB."}));
		day1Mails.Add (new FMail (95f,	"BOB",	"RE:MAIL",	 new string[] {"I NEVER", "DO THAT!", "", ""},	false,	false,	false,	new string[]{}));
		day1Mails.Add (new FMail (100f,	"MIKE",	"RE:MAIL",	 new string[] {"YEAH!", "LEAVE BOB", "ALONE", ""},	false,	false,	false,	new string[]{}));
		day1Mails.Add (new FMail (105f,	"JEFF",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F3"},	true,	false,	false,	new string[]{}));
		day1Mails.Add (new FMail (110f,	"ALEX",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F2"},	true,	false,	false,	new string[]{}));
		day1Mails.Add (new FMail (115f,	"IT",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F1"},	true,	false,	false,	new string[]{}));

		bf.Serialize (streamM1, day1Mails);
		streamM1.Close ();


		FileStream streamA1 = new FileStream (Application.dataPath + "/Day_1_Ads.sav", FileMode.Create);

		List<FAd> day1Ads = new List<FAd> ();
		//No ads day 1
		//day1Ads.Add (new FAd (1f, 0, 2f));

		bf.Serialize (streamA1, day1Ads);
		streamA1.Close ();

		//-------------------------------------------------------------------- Day 2 --------------------------------------------------------------
		FileStream streamM2 = new FileStream (Application.dataPath + "/Day_2_Mails.sav", FileMode.Create);

		List<FMail> day2Mails = new List<FMail> ();
		day2Mails.Add (new FMail (1f,	"IT",	"MAIL",	 new string[] {"HI.JUST", "A REMINDER", "PLEASE DO", "NOT REPLY"},	false,	false,	false,	new string[]{"NO REPLY ALL", "I AM TALKING", "TO YOU BOB."}));
		day2Mails.Add (new FMail (5f,	"BOB",	"RE:MAIL",	 new string[] {"OKAY. I", "WILL STOP", "", ""},	false,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (10f,	"MIKE",	"RE:MAIL",	 new string[] {"NEVER!", "", "", ""},	false,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (15f,	"IT",	"RE:MAIL",	 new string[] {"MIKE!", "", "", ""},	false,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (25f,	"MIKE",	"RE:MAIL",	 new string[] {"OKAY...", "", "", ""},	false,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (30f,"IT",	"VIRUS", new string[] {"READ", "THE FILE", "", ""},	false, true,	false, new string[]{"VIRUS", "SO SOMEONE HAS", "OPENED AN", "EMAIL THAT HAD", "A VIRUS.NOW", "EVERYONE IS", "GETTING ADS", "PLEASE CLOSE", "THEM"}));
		day2Mails.Add (new FMail (45f,"IT",	"VIRUS", new string[] {"FOLLOW UP.","READ", "THE FILE", ""},	false, true,	false, new string[]{"VIRUS", "EACH WINDOW", "TAKES UP RAM.", "IF RAM GETS", "TO FULL YOU", "WILL BE FIRED", "", "", "THANKS BOB..."}));
		day2Mails.Add (new FMail (55f,	"BOB",	"RE:VIRUS",	 new string[] {"I ONLY", "WANTED TO", "SEE WHAT", "THEY SOLD"},	false,	true,	false,	new string[]{}));
		day2Mails.Add (new FMail (60f,	"MIKE",	"RE:MAILS",	 new string[] {"IT HAPPENS", "TO THE BEST", "OF US", ""},	false,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (65f,	"JEFF",	"FILE",	 new string[] {"HI.", "HAS ANYONE", "SEEN MY:", "FILE"},	false,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (70f,	"ALEX",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F2"},	true,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (75f,	"IT",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F1"},	true,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (80f,	"BOB",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F3"},	true,	true,	true,	new string[]{}));
		day2Mails.Add (new FMail (85f,	"ALEX",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F4"},	true,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (90f,	"MIKE",	"FILE",	 new string[] {"HI.", "HAS ANYONE", "SEEN MY:", "FILE"},	false,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (95f,	"JEFF",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F3"},	true,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (100f,	"ALEX",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F2"},	true,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (105f,	"IT",	"FILE",	 new string[] {"HI.", "HAS ANYONE", "SEEN MY:", "FILE"},	false,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (110f,	"BOB",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F3"},	true,	true,	true,	new string[]{}));
		day2Mails.Add (new FMail (115f,	"ALEX",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F4"},	true,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (120f,	"MIKE",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F5"},	true,	false,	false,	new string[]{}));


		bf.Serialize (streamM2, day2Mails);
		streamM2.Close ();


		FileStream streamA2 = new FileStream (Application.dataPath + "/Day_2_Ads.sav", FileMode.Create);

		List<FAd> day2Ads = new List<FAd> ();
		day2Ads.Add (new FAd (1f, 20, 10f));
		day2Ads.Add (new FAd (30f, 4, 0.1f));
		day2Ads.Add (new FAd (60f, 4, 0.1f));
		day2Ads.Add (new FAd (90f, 4, 0.1f));

		bf.Serialize (streamA2, day2Ads);
		streamA2.Close ();

		/*
		//-------------------------------------------------------------------- Day 3 --------------------------------------------------------------
		FileStream streamM3 = new FileStream (Application.dataPath + "/Day_3_Mails.sav", FileMode.Create);

		List<FMail> day3Mails = new List<FMail> ();
		day3Mails.Add (new FMail (1f,	"BOSS",	"INTRO",	 new string[] {"WELL DONE", "KEEP GOING", "AND READ", "FILE"},	true,	true,	false,	new string[]{"INSTRUCTIONS3", "HELLO", "HOW ARE YOU TODAY?"}));

		bf.Serialize (streamM3, day3Mails);
		streamM3.Close ();


		FileStream streamA3 = new FileStream (Application.dataPath + "/Day_3_Ads.sav", FileMode.Create);

		List<FAd> day3Ads = new List<FAd> ();
		day3Ads.Add (new FAd (1f, 5, 0.1f));

		bf.Serialize (streamA3, day3Ads);
		streamA3.Close ();
		
	}
	*/

	void SaveDaysWeb() {
		List<FMail> day1Mails = new List<FMail> ();
		day1Mails.Add (new FMail (1f,	"BOSS",	"INFO 1",	 new string[] {"HI.WELCOME", "TO THE JOB.", "READ FILE", "PLEASE"},	false,	true,	false,	new string[]{"INSTRUCTIONS", "YOUR JOB IS TO", "SEND FILES TO", "PEOPLE WHO", "NEED THEM.", "YOU WORK FROM", "09:00 TO 17:00.", "NO BREAKS!"}));
		day1Mails.Add (new FMail (15f,	"BOSS",	"INFO 2",	 new string[] {"FOLLOW UP", "READ FILE", "SEND ME:", "F5"},	true,	true,	false,	new string[]{"INSTRUCTIONS", "PRESS SEND", "TO SEND FILE.", "DO NOT SEND", "FILES UNLESS", "PEOPLE ASKED", "YOU TO. ONLY", "SEND ONE FILE."}));
		day1Mails.Add (new FMail (30f,	"BOSS",	"INFO 3",	 new string[] {"FOLLOW UP", "", "READ FILE", "PLEASE"},	false,	true,	false,	new string[]{"INSTRUCTIONS", "IF YOU SEND", "FILE CORRECTLY", "YOU GET PAID.", "OTHERWISE YOU", "GET A PENALTY.", "IF DO NOT SEND", "WHEN ASKED YOU", "GET A PENALTY."}));
		day1Mails.Add (new FMail (45f,	"BOSS",	"INFO 4",	 new string[] {"FOLLOW UP", "", "READ FILE", "PLEASE"},	false,	true,	false,	new string[]{"INSTRUCTIONS", "INBOX SIZE IS", "LIMITED.", "", "PLEASE KEEP", "YOUR INBOX", "EMPTY OR YOU", "WILL BE FIRED."}));
		day1Mails.Add (new FMail (60f,	"IT",	"PC",	 new string[] {"HI. PLEASE", "READ PC", "USE RULES", "SEND F1"},	true,	true,	false,	new string[]{"PC USE RULES", "YOU HAVE YOUR", "ICONS ON THE", "LEFT IN ORDER:", "1.INLOOK.", "2.ACCESS LIST.", "3.RAM STATUS.", ""}));
		day1Mails.Add (new FMail (75f,	"IT",	"PC",	 new string[] {"FOLLOW UP.", "", "", "READ FILE"},	false,	true,	false,	new string[]{"PC USE RULES", "YOU CAN MOVE", "WINDOWS AROUND", "ON YOUR SCREEN", "THE SPACE IS", "LIMITED SO JUST", "KEEP IT TIDY.", "", "GOOD LUCK :)"}));
		day1Mails.Add (new FMail (90f,	"IT",	"MAIL",	 new string[] {"HI.JUST", "A REMINDER", "PLEASE", "READ FILE"},	false,	true,	false,	new string[]{"NO REPLY ALL", "I AM TALKING", "TO YOU BOB."}));
		day1Mails.Add (new FMail (95f,	"BOB",	"RE:MAIL",	 new string[] {"I NEVER", "DO THAT!", "", ""},	false,	false,	false,	new string[]{}));
		day1Mails.Add (new FMail (100f,	"MIKE",	"RE:MAIL",	 new string[] {"YEAH!", "LEAVE BOB", "ALONE", ""},	false,	false,	false,	new string[]{}));
		day1Mails.Add (new FMail (105f,	"JEFF",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F3"},	true,	false,	false,	new string[]{}));
		day1Mails.Add (new FMail (110f,	"ALEX",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F2"},	true,	false,	false,	new string[]{}));
		day1Mails.Add (new FMail (115f,	"IT",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F1"},	true,	false,	false,	new string[]{}));
		myMails1 = day1Mails;

		List<FAd> day1Ads = new List<FAd> ();
		myAds1 = day1Ads;

		List<FMail> day2Mails = new List<FMail> ();
		day2Mails.Add (new FMail (1f,	"IT",	"MAIL",	 new string[] {"HI.JUST", "A REMINDER", "PLEASE DO", "NOT REPLY"},	false,	false,	false,	new string[]{"NO REPLY ALL", "I AM TALKING", "TO YOU BOB."}));
		day2Mails.Add (new FMail (5f,	"BOB",	"RE:MAIL",	 new string[] {"OKAY. I", "WILL STOP", "", ""},	false,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (10f,	"MIKE",	"RE:MAIL",	 new string[] {"NEVER!", "", "", ""},	false,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (15f,	"IT",	"RE:MAIL",	 new string[] {"MIKE!", "", "", ""},	false,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (25f,	"MIKE",	"RE:MAIL",	 new string[] {"OKAY...", "", "", ""},	false,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (30f,"IT",	"VIRUS", new string[] {"READ", "THE FILE", "", ""},	false, true,	false, new string[]{"VIRUS", "SO SOMEONE HAS", "OPENED AN", "EMAIL THAT HAD", "A VIRUS.NOW", "EVERYONE IS", "GETTING ADS", "PLEASE CLOSE", "THEM"}));
		day2Mails.Add (new FMail (45f,"IT",	"VIRUS", new string[] {"FOLLOW UP.","READ", "THE FILE", ""},	false, true,	false, new string[]{"VIRUS", "EACH WINDOW", "TAKES UP RAM.", "IF RAM GETS", "TO FULL YOU", "WILL BE FIRED", "", "", "THANKS BOB..."}));
		day2Mails.Add (new FMail (55f,	"BOB",	"RE:VIRUS",	 new string[] {"I ONLY", "WANTED TO", "SEE WHAT", "THEY SOLD"},	false,	true,	false,	new string[]{}));
		day2Mails.Add (new FMail (60f,	"MIKE",	"RE:MAILS",	 new string[] {"IT HAPPENS", "TO THE BEST", "OF US", ""},	false,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (65f,	"JEFF",	"FILE",	 new string[] {"HI.", "HAS ANYONE", "SEEN MY:", "FILE"},	false,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (70f,	"ALEX",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F2"},	true,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (75f,	"IT",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F1"},	true,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (80f,	"BOB",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F3"},	true,	true,	true,	new string[]{}));
		day2Mails.Add (new FMail (85f,	"ALEX",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F4"},	true,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (90f,	"MIKE",	"FILE",	 new string[] {"HI.", "HAS ANYONE", "SEEN MY", "FILE"},	false,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (95f,	"JEFF",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F3"},	true,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (100f,	"ALEX",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F2"},	true,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (105f,	"IT",	"FILE",	 new string[] {"HI.", "HAS ANYONE", "SEEN MY", "FILE"},	false,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (110f,	"BOB",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F3"},	true,	true,	true,	new string[]{}));
		day2Mails.Add (new FMail (115f,	"ALEX",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F4"},	true,	false,	false,	new string[]{}));
		day2Mails.Add (new FMail (120f,	"MIKE",	"FILE",	 new string[] {"HI.", "", "SEND ME:", "F5"},	true,	false,	false,	new string[]{}));
		myMails2 = day2Mails;

		List<FAd> day2Ads = new List<FAd> ();
		day2Ads.Add (new FAd (1f, 20, 10f));
		day2Ads.Add (new FAd (30f, 4, 0.1f));
		day2Ads.Add (new FAd (60f, 4, 0.1f));
		day2Ads.Add (new FAd (90f, 4, 0.1f));
		myAds2 = day2Ads;
	}

}

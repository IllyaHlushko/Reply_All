using System;
using System.Collections.Generic;

[Serializable]
public class FMail {
	public float spawnDelay;
	public string from;
	public string subject;
	public string[] content;
	public bool needsFile;
	public bool hasFile;
	public bool virus;
	public string[] myFile;

	public FMail (float spawnDelayL, string fromL, string subjectL, string[] contentL, bool needsFileL, bool hasFileL, bool virusL, string[] myFileL) {
		spawnDelay = spawnDelayL;
		from = fromL;
		subject = subjectL;
		content = contentL;
		needsFile = needsFileL;
		hasFile = hasFileL;
		virus = virusL;
		myFile = myFileL;
	}
}
[Serializable] 
public class FAd {
	public float delayTime;
	public int repeat;
	public float repeatDelayTime;

	public FAd (float delayTimeL, int repeatL, float repeatDelayTimeL) {
		delayTime = delayTimeL;
		repeat = repeatL;
		repeatDelayTime = repeatDelayTimeL;
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsHandler : MonoBehaviour {

	public static bool SoundOn;

	public Text soundText;

	void Start(){
		//print (SoundOn);
		Sound ();
	}

	public void Sound(){
		if (SoundOn) {
			SoundOn = false;
			AudioListener.volume = 1.0f;
			soundText.text = "Sound OFF";
		} else if(!SoundOn) {
			SoundOn = true;
			AudioListener.volume = 0.0f;
			soundText.text = "Sound ON";
		}
	}
}

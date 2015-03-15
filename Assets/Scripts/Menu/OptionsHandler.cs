using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsHandler : MonoBehaviour {
	public Text soundText;

	public void Sound(){
		if (AudioListener.pause) {
			AudioListener.pause = false;
			soundText.text = "Sound OFF";
		} else if(!AudioListener.pause) {
			AudioListener.pause = true;
			soundText.text = "Sound ON";
		}
	}
}

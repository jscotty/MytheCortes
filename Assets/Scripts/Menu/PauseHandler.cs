using UnityEngine;
using System.Collections;

public class PauseHandler : MonoBehaviour {

	private bool _paused;

	void OnApplicationPause(bool pauseStatus) {
		_paused = pauseStatus;
	}

	void Update(){
		if (_paused) {
			Time.timeScale = 0.0f;		
		} else {
			Time.timeScale = 1.0f;
		}
	}
}

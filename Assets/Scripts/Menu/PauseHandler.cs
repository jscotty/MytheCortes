using UnityEngine;
using System.Collections;

public class PauseHandler : MonoBehaviour {
	
	[SerializeField]
	private SaveLoadDataSerialized save;
	[SerializeField]
	private PauseScript _pauseScript;
	private bool _paused;

	void Start(){
		Time.timeScale = 1.0f;
	}

	void OnApplicationFocus(bool pauseStatus) {
		_paused = pauseStatus;
		if (! _paused) {
			_pauseScript.SetPaused();
			save.Save();
		}
	}
}

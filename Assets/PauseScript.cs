using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {
	public static bool paused = false;

	/// <summary>
	/// 0 = PlayerUI
	/// 1 = PauseUI
	/// </summary>
	public GameObject[] _ui;

	void Start(){
		_ui[0].SetActive(true);
		_ui[1].SetActive(false);
	}

	public void OnClick(){
		if (paused) {
			paused = false;
			_ui[0].SetActive(true);
			_ui[1].SetActive(false);
		} else {
			paused = true;
			_ui[0].SetActive(false);
			_ui[1].SetActive(true);
		}
	}
}

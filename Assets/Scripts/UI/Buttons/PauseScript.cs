using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {
	private bool _paused = false;

	/// <summary>
	/// 0 = PlayerUI
	/// 1 = PauseUI
	/// </summary>
	public GameObject[] _ui;

	void Start(){
		Time.timeScale = 1.0f;
		_ui[0].SetActive(true);
		_ui[1].SetActive(false);
	}

	void Update(){
		if (Time.timeScale == 0f) {
			SetPaused();
		}
	}

	public void Paused(){
		if (_paused) {
			_paused = false;
			_ui[0].SetActive(true);
			_ui[1].SetActive(false);
			Time.timeScale = 1.0f;
		} else {
			_paused = true;
			_ui[0].SetActive(false);
			_ui[1].SetActive(true);
			Time.timeScale = 0.0f;
		}
	}
	public void SetPaused(){
			_paused = true;
			_ui[0].SetActive(false);
			_ui[1].SetActive(true);
			Time.timeScale = 0.0f;
	}
}

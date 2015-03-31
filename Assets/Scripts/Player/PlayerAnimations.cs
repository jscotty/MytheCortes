using UnityEngine;
using System.Collections;

public class PlayerAnimations : MonoBehaviour {
	public InteractHandler interactHandler;
	public PlayerController playerController;
	public AudioClip audioClip;
	public GameObject deathScreen;

	Animator _anim;
	Joystick _joystick;

	float _xAxis,_yAxis,_count;
	bool _attack, _talk;

	AudioSource _audio;

	void Start(){
		_anim = gameObject.GetComponent<Animator> ();
		_audio = gameObject.GetComponent<AudioSource> ();

		GameObject joystick = GameObject.FindGameObjectWithTag (Tags.JOYSTICK_CONTROLLER);
			_joystick = joystick.GetComponent<Joystick> ();
		
	}

	void Update(){
		if (_joystick != null) {
			_xAxis = _joystick.xAxis;
			_yAxis = _joystick.yAxis;
			_attack = interactHandler.attack;
			_talk = interactHandler.talk;

			if (_xAxis >= 1f || _yAxis >= 1f || _xAxis <= -1f || _yAxis <= -1f) {
				_anim.SetBool(AnimNames.WALK, true);
			}else {
				_anim.SetBool(AnimNames.WALK, false);	
			}
		}

		if (PlayerData.health <= 0) {
			PlayerData.health = 0;
			_anim.SetBool(AnimNames.DEATH, true);	
		}
	}

	public void StopAttack(){
		_anim.SetBool(AnimNames.ATTACK, false);
		playerController.attack = false;
		playerController.move = true;
		_joystick.interact = false;
		_count = 0;
	}

	public void StartAttack(){
		if (gameObject.activeSelf) {
			_joystick.interact = true;
			if (!_talk) {
				_anim.SetBool(AnimNames.ATTACK, true);
				playerController.attack = true;
				playerController.move = false;
				//_joystick.interact = true;
				_count ++;
				if(_count == 1f)
					_audio.PlayOneShot(audioClip, 1f);
			}
		} else {
		}
	}

	public void Death(){
		deathScreen.SetActive (true);
		Application.LoadLevel (4);
	}
}

using UnityEngine;
using System.Collections;

public class PlayerAnimations : MonoBehaviour {
	public InteractHandler interactHandler;
	public PlayerController playerController;
	Animator _anim;
	Joystick _joystick;

	float _xAxis,_yAxis,_count;
	bool _attack, _talk;

	AudioSource _audio;
	public AudioClip audioClip;

	void Start(){
		_anim = gameObject.GetComponent<Animator> ();
		_audio = gameObject.GetComponent<AudioSource> ();

		GameObject joystick = GameObject.FindGameObjectWithTag (Tags.JOYSTICK_CONTROLLER);
		if (joystick != null) 
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
			
			if (!_talk) {
				_anim.SetBool(AnimNames.ATTACK, true);
				//playerController.attack = true;
				playerController.move = false;
				//_joystick.interact = false;
				_count ++;
				if(_count == 1f)
					_audio.PlayOneShot(audioClip, 1f);
			}
		} else {

		}
	}
}

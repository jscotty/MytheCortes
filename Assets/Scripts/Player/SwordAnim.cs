using UnityEngine;
using System.Collections;

public class SwordAnim : MonoBehaviour {
	private bool _attack, _talk;

	Joystick _joystick;
	PlayerController _playerController;
	DummyBehaviour _dummy;

	void Start(){
		_talk = false;

		GameObject joystickController = GameObject.FindGameObjectWithTag (Tags.JOYSTICK_CONTROLLER);
		if(joystickController != null)
			_joystick = joystickController.GetComponent<Joystick> ();

		GameObject player = GameObject.FindGameObjectWithTag (Tags.PLAYER);
		_playerController = player.GetComponent<PlayerController> ();

	}

	void Update(){
		if(_joystick != null){
			if (_attack == true && !_talk) {
				_playerController.attack = _attack;
				//_playerController.move = false;
				//collider2D.isTrigger = true;
			} else {
				_attack = _joystick.interact;
			}
		}
	}

	public void StopAttack(){
		_attack = false;
		print ("jah");

		_joystick.interact = _attack;
		_playerController.attack = _attack;
		_playerController.move = true;
	}

	#region getters and setters
	public bool talk{
		set{
			_talk = value;
		}
		get{
			return _talk;
		}
	}
	public bool attack{
		set{
			_attack = value;
		}
	}
	#endregion
}

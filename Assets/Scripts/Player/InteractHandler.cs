using UnityEngine;
using System.Collections;

public class InteractHandler : MonoBehaviour {
	private bool _attack, _move, _talk;
	
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
				_move = false;
				_talk = false;
				_playerController.attack = _attack;
				_playerController.move = _move;
				//collider2D.isTrigger = true;
			} else {
				_attack = _joystick.interact;
			}
		}
	}
	
	public void StopAttack(){
		_attack = false;
		_move = true;
		
		_joystick.interact = _attack;
		_playerController.attack = _attack;
		_playerController.move = _move;
	}
	
	#region getters and setters
	public bool talk{
		get{
			return _talk;
		}
		set{
			_talk = value;
		}
	}
	public bool attack{
		get{
			return _attack;
		}
		set{
			_attack = value;
		}
	}
	#endregion
}


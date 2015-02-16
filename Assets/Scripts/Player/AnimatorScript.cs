using UnityEngine;
using System.Collections;

public class AnimatorScript : MonoBehaviour {

	Animator swordAnim;
	private bool _attack, _move, _talk;

	Joystick _joystick;
	PlayerController _playerController;
	DummyBehaviour _dummy;

	void Start(){
		_talk = false;
		swordAnim = GetComponent<Animator> ();

		GameObject joystickController = GameObject.FindGameObjectWithTag (Tags.JOYSTICK_CONTROLLER);
		_joystick = joystickController.GetComponent<Joystick> ();

		GameObject player = GameObject.FindGameObjectWithTag (Tags.PLAYER);
		_playerController = player.GetComponent<PlayerController> ();

	}

	void Update(){
		if (_attack == true && !_talk) {
			swordAnim.SetBool("Attack", true);
			_move = false;
			_playerController.SetAttack (_attack);
			_playerController.SetMove (_move);
			//collider2D.isTrigger = true;
		} else{
			_attack = _joystick.GetInteract();
		}
	}

	public void StopAttack(){
		swordAnim.SetBool("Attack", false);	
		_attack = false;
		_move = true;

		_joystick.SetInteract (_attack);
		_playerController.SetAttack (_attack);
		_playerController.SetMove (_move);
	}

	#region getters and setters
	public bool talk{
		set{
			_talk = value;
		}
	}
	public bool attack{
		set{
			_attack = value;
		}
	}
	#endregion
}

using UnityEngine;
using System.Collections;

public class AnimatorScript : MonoBehaviour {

	Animator swordAnim;
	private bool _attack, _move;

	Joystick _joystick;
	PlayerController _playerController;
	DummyBehaviour _dummy;
	
	void Start(){
		swordAnim = GetComponent<Animator> ();

		GameObject joystickController = GameObject.FindGameObjectWithTag ("JoystickController");
		_joystick = joystickController.GetComponent<Joystick> ();

		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		_playerController = player.GetComponent<PlayerController> ();

		GameObject enemy = GameObject.FindGameObjectWithTag ("Enemy");
		_dummy = enemy.GetComponent<DummyBehaviour> ();



	}

	void Update(){
		if (_attack == true) {
			swordAnim.SetBool("Attack", true);
			_move = false;
			_playerController.SetAttack (_attack);
			_playerController.SetMove (_move);
			_dummy.SetDamaging(_attack);
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
		_dummy.SetDamaging(_attack);

	
	}

	#region getters and setter
	public bool GetMove(){
		return _move;
	}
	public bool GetAttack(){
		return _attack;
	}
	#endregion
}

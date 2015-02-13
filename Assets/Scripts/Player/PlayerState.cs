using UnityEngine;
using System.Collections;

public class PlayerState : MonoBehaviour {

	private bool _attack;
	private bool _move;
	private bool _interact;

	#region getter and setter for attack
	public bool GetAttack(){
		return _attack;
	}

	public void SetAttack(bool value){
		_attack = value;
	}
	#endregion

	#region getter and setter for move
	public bool GetMove(){
		return _move;
	}
	
	public void SetMove(bool value){
		_move = value;
	}
	#endregion
	
	#region getter and setter for interaction
	public bool GetInteract(){
		return _interact;
	}
	
	public void SetInteract(bool value){
		_interact = value;
	}
	#endregion
}

using UnityEngine;
using System.Collections;

public class PlayerState : MonoBehaviour {

	private bool _attack;
	private bool _move;
	private bool _interact;

	#region getter and setter for attack

	public bool attack {
		get {
			return _attack;
		}
		set {
			_attack = value;
		}
	}

	#endregion

	#region getter and setter for move
	
	public bool move {
		get {
			return _move;
		}
		set {
			_move = value;
		}
	}

	#endregion
	
	#region getter and setter for interaction
	
	public bool interact {
		get {
			return _interact;
		}
		set {
			_interact = value;
		}
	}

	#endregion
}

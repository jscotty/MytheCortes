using UnityEngine;
using System.Collections;

public class Joystick : MonoBehaviour {

	private float _xAxis,_yAxis;

	private bool _interact;

	enum Direction { North, South, West, East, Idle};

	void Start(){
		Direction myDirection;

		myDirection = Direction.North;


	}

	Direction ReverseDirection(Direction dir){
		if (dir == Direction.North) {
			_xAxis = 0f;
			_yAxis = 1f;
		} else if(dir == Direction.South){
			_xAxis = 0f;
			_yAxis = -1f;
		} else if(dir == Direction.West){
			_xAxis = -1f;
			_yAxis = 0f;
		} else if(dir == Direction.East){
			_xAxis = 1f;
			_yAxis = 0f;
		}

		return dir;
	}

	public void OnDown(string button){
		if (button == "RIGHT") {
			ReverseDirection(Direction.East);
		} else if (button == "LEFT") {
			ReverseDirection(Direction.West);
		} else if (button == "UP") {
			ReverseDirection(Direction.North);
		} else if (button == "DOWN") {
			ReverseDirection(Direction.South);
		} else if (button == "INTERACT") {
			_interact = true;
		}
	}
	
	public void OnUP(){
		_xAxis = 0f;
		_yAxis = 0f;
		_interact = false;
	}

	#region getters and setters
	public float yAxis {
		get {
			return _yAxis;
		}
		set {
			_yAxis = value;
		}
	}
	
	public float xAxis {
		get {
			return _xAxis;
		}
		set {
			_xAxis = value;
		}
	}
	
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

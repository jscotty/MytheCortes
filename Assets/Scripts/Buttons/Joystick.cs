using UnityEngine;
using System.Collections;

public class Joystick : MonoBehaviour {

	private float _xAxis,_yAxis;

	private bool _interact;

	public void OnDown(string button){
		if (button == "RIGHT") {
			_xAxis = 1f;
			_yAxis = 0f;
		} else if (button == "LEFT") {
			_xAxis = -1f;
			_yAxis = 0;
		} else if (button == "UP") {
			_xAxis = 0;
			_yAxis = 1f;
		} else if (button == "DOWN") {
			_xAxis = 0;
			_yAxis = -1f;
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
	public float GetXAxis(){
		return _xAxis;
	}
	
	public float GetYAxis(){
		return _yAxis;
	}
	
	public bool GetInteract(){
		return _interact;
	}
	
	public void SetInteract(bool value){
		_interact = value;
	}
	#endregion
}

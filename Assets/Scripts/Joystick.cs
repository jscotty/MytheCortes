using UnityEngine;
using System.Collections;

public class Joystick : MonoBehaviour {

	public RectTransform moveStick;
	private Vector3 joystick;

	public float jXaxis;
	public float jYaxis;

	private bool move;

	void Start(){
		transform.position = new Vector2 (100f,100f);

		joystick = transform.position;
	}

	void Update(){
		if (move) {
			if(joystick.x < 50 || joystick.x > 150 || joystick.y < 50 || joystick.y > 150){
				joystick = Input.mousePosition;
			}else{
				joystick = Input.mousePosition;
			}
			transform.position = joystick;

			jXaxis = (joystick.x / 100f) - 1f;
			jYaxis = (joystick.y / 100f) - 1f;

			jXaxis = Mathf.Clamp(jXaxis, -1, 1);
			jYaxis = Mathf.Clamp(jYaxis, -1, 1);

			//print("jXaxis (" + jXaxis + ") jYacis (" + jYaxis + ")");

			//print(joystick);
		} else {
			transform.position = new Vector2 (100f,100f);
			jXaxis = 0f;
			jYaxis = 0f;
		}
	}

	public void OnDown(){
		move = true;
	}

	public void OnUp(){
		joystick = transform.position;
		move = false;
	}
}

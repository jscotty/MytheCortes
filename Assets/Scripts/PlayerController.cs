using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 2f;
	//public float rotSpeed = 2f;

	GameObject joystick;
	Vector3 player;

	float xAxis;
	float yAxis;
	float rot;

	void Start(){
		joystick = GameObject.FindGameObjectWithTag ("Joystick");
		player = transform.position;
	}

	void Update () {
		xAxis = joystick.GetComponent<Joystick> ().jXaxis;
		yAxis = joystick.GetComponent<Joystick> ().jYaxis;

		player.x += xAxis * speed * Time.deltaTime;
		player.z += yAxis * speed * Time.deltaTime;

		rot = (player.x * player.z + 90);

		transform.Translate (new Vector2 (xAxis,  yAxis) * speed * Time.deltaTime);

		//transform.position = player;


		//print (rot);

	}
}

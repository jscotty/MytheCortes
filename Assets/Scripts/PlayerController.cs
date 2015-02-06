using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 2f;
	
	public float x,y;
	public GameObject[] joystick;

	void Start(){

	}

	void Update () {
		transform.Translate (new Vector2 (x, y) * speed * Time.deltaTime);

	}
}

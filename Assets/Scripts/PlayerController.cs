using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 12f;
	
	public float x,y;
	Vector2 player;

	Rigidbody2D body;
	Transform trans;

	void Start(){
		body = rigidbody2D;
		trans = transform;
	}

	void FixedUpdate () {
		// moving with Velocity for an stable collision ( without shake bounding )
		Vector2 moveVelocity = body.velocity;
		moveVelocity.x = x * speed;
		moveVelocity.y = y * speed;
		body.velocity = moveVelocity;
	}

	void Update(){
		//rotating player:
		Rotate ();
	}

	private void Rotate(){
		if (x > 0f && y == 0f) {
			transform.eulerAngles = new Vector3(0f, 0f,270f);
		} else if (x < 0f && y == 0f) {
			transform.eulerAngles = new Vector3(0f, 0f, 90f);
		} else if (x == 0f && y > 0f) {
			transform.eulerAngles = new Vector3(0f, 0f, 0f);
		} else if (x == 0f && y < 0f) {
			transform.eulerAngles = new Vector3(0f, 0f, 180f);
		}
	}
}

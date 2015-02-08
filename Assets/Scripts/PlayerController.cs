using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 12f;
	
	public float x,y;
	public bool attack;
	public bool move;

	Vector2 player;

	Rigidbody2D body;
	Transform trans;

	void Start(){
		move = true;
		body = rigidbody2D;
		trans = transform;
	}

	void FixedUpdate () {
		if (move) {
			MovePlayer();
		}else{

		}
	}

	void Update(){
		if (move) {
			Rotate ();
		}else {

		}
	}

	private void MovePlayer(){
		// moving with Velocity for an stable collision ( without shake bounding )
		Vector2 moveVelocity = body.velocity;
		moveVelocity.x = x;
		moveVelocity.y = y;
		body.velocity = moveVelocity * speed;
	}
	
	private void Rotate(){
		//rotating player:
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

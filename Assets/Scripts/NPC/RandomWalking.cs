using UnityEngine;
using System.Collections;

public class RandomWalking : MonoBehaviour {
	
	public float speed;
	
	private float _time;
	private int _dirX, _dirY;
	private Rigidbody2D _body;
	private Vector2 _scale;
	private bool _move = true;

	void Start(){
		_body = gameObject.GetComponent<Rigidbody2D>();
		_time = 2f;

		_scale.y = 1;
	}

	void FixedUpdate(){
		if (move) {
			_time += Time.deltaTime;
			
			if(_time > 2f){
				float ranNum = Random.Range(0, 10);
				RandomMovement(ranNum);
				_time = 0f;
				
				if (_dirX < 0) {
					_scale.x = 1;
				} else {
					_scale.x = -1;
				}
			}
			transform.localScale = _scale;
		} else {
			_dirX = 0;
			_dirY = 0;
		}

		Move ();
	}

	void RandomMovement(float value){
		if (value >= 5f) {
			float ranNum = Random.Range(0,2);
			if(ranNum == 0){
				_dirX = Random.Range (-1,2);
				_dirY = 0;
			} else {
				_dirX = 0;
				_dirY = Random.Range (-1,2);
			}
		} else {
			_dirX = 0;
			_dirY = 0;
		}
	}

	void Move(){
		Vector2 moveVelocity = _body.velocity;
		moveVelocity.x = _dirX;
		moveVelocity.y = _dirY;
		_body.velocity = moveVelocity * speed;

	}
	#region Getters and setters
	public int dirX {
		get {
			return _dirX;
		}
		set {
			_dirX = value;
		}
	}

	public int dirY {
		get {
			return _dirY;
		}
		set {
			_dirY = value;
		}
	}
	
	public bool move {
		get {
			return _move;
		}
		set {
			_move = value;
		}
	}
	#endregion
}

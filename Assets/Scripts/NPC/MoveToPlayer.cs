using UnityEngine;
using System.Collections;

public class MoveToPlayer : MonoBehaviour {
	public float speed;
	public Transform player;

	[SerializeField]
	private float _maxRange;

	private float _minRange;
	private float _dirX, _dirY;
	private float _difX, _difY;
	private Vector2 playerPosition;
	private Vector2 position;
	private Rigidbody2D _body;
	private bool _move;

	void Start(){
		_body = gameObject.GetComponent<Rigidbody2D> ();
		_move = true;
		_minRange = -_maxRange;
	}

	void Update(){
		if (_move) {
			playerPosition = player.transform.position;
			position = transform.position;
			
			_difX = position.x - playerPosition.x;
			_difY = position.y - playerPosition.y;
			float dif;

			if(_difX > _maxRange && _difY < _maxRange){
				dif = _difX - _difY;
			} else if(_difX < _maxRange && _difY < _maxRange){
				dif = _difX + _difY;
			} else if(_difX > _maxRange && _difY > _maxRange){
				dif = _difX + _difY;
			} else if(_difX < _maxRange && _difY > _maxRange){
				dif = _difX - _difY;
			} else {
				dif = _difX + _difY;
			}
			//print(dif + " | difx: " + _difX + " | dify: " + _difY);
			if (dif < _maxRange || dif > _minRange) {
				_dirX = 0f;
				_dirY = 0f;
			} if (dif > _maxRange || dif < _minRange) {
				if (_difX > _maxRange && _difY < _maxRange) {
					_dirX = -1f;
					_dirY = 0f;
				} else if (_difX < _maxRange && _difY > _maxRange) {
					_dirX = 0f;
					_dirY = -1f;
				} else if (_difX > _maxRange && _difY > _maxRange) {
					if(_difX > _difY){
						_dirX = -1f;
						_dirY = 0f;
					} else if(_difX < _difY){
						_dirX = 0f;
						_dirY = -1f;
					}
				} else if (_difX < _maxRange && _difY < _maxRange) {
					if(_difX < _difY){
						_dirX = 1f;
						_dirY = 0f;
					} else if(_difX > _difY) {
						_dirX = 0f;
						_dirY = 1f;
					}
				} else {
					_dirX = 0f;
					_dirY = 0f;
				}
				//print ("X: " + _difX + "| Y: " + _difY);
			}
		} else {
			_dirX = 0f;
			_dirY = 0f;
		}
		//print (_move);
		Move ();

	}

	void Move(){
		Vector2 moveVelocity = _body.velocity;
		moveVelocity.x = _dirX;
		moveVelocity.y = _dirY;
		_body.velocity = moveVelocity * speed;
	}
	
	#region Getters and Setters
	public float dirX {
		get{
			return _dirX;
		}
		set{
			_dirX = value;
		}
	}

	public float dirY {
		get{
			return _dirY;
		}
		set{
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

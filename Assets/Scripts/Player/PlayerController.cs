using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 12f;
	
	public float x,y;
	private bool _attack, _move;

	public Transform sword;

	/// <summary>
	/// The character sprites.
	/// 0 = is down
	/// 1 = up
	/// 2 = left and right
	/// </summary>
	public Sprite[] characterSprites;
	SpriteRenderer _spriteRenderer;
	Vector2 _scale;

	Rigidbody2D _body;
	Transform _trans;
	
	Joystick _joystick;

	CharacterData _playerData;

	void Start(){
		_scale.x = 1;
		_scale.y = 1;
		_move = true;
		_body = rigidbody2D;
		_trans = transform;

		GameObject joystickController = GameObject.FindGameObjectWithTag (Tags.JOYSTICK_CONTROLLER);
		if(joystickController != null)
			_joystick = joystickController.GetComponent<Joystick> ();

		_spriteRenderer = gameObject.GetComponent<SpriteRenderer> ();
		_playerData = gameObject.GetComponent<CharacterData> ();
	}

	void FixedUpdate () {
		if (_move) {
			MovePlayer();
			Rotate ();
		} else {
			_body.velocity = new Vector2(0f,0f);
		}
	}

	/// <summary>
	/// Moves the player.
	/// </summary>
	private void MovePlayer(){
		if (_joystick != null) {
			x = _joystick.GetXAxis ();
			y = _joystick.GetYAxis ();
		}
		// moving with Velocity for an stable collision ( without shake bounding )
		Vector2 moveVelocity = _body.velocity;
		moveVelocity.x = x;
		moveVelocity.y = y;
		_body.velocity = moveVelocity * speed;
	}

	/// <summary>
	/// Rotates / changes the sprite of the player.
	/// </summary>
	private void Rotate(){
		//rotating player:
		if (x > 0f && y == 0f) { // right
			sword.transform.eulerAngles = new Vector3(0f, 0f,90f);
			_spriteRenderer.sprite = characterSprites[2];
			_scale.x = -1;
		} else if (x < 0f && y == 0f) { // left
			sword.transform.eulerAngles = new Vector3(0f, 0f, 90f);
			_spriteRenderer.sprite = characterSprites[2];
			_scale.x = 1;
		} else if (x == 0f && y > 0f) { // up
			sword.transform.eulerAngles = new Vector3(0f, 0f, 0f);
			_spriteRenderer.sprite = characterSprites[1];
		} else if (x == 0f && y < 0f) { // down
			sword.transform.eulerAngles = new Vector3(0f, 0f, 180f);
			_spriteRenderer.sprite = characterSprites[0];
		}
		transform.localScale = _scale;
	}

	#region getters and setters
	public bool GetAttack(){
		return _attack;
	}

	public void SetAttack(bool value){
		_attack = value;
	}

	public bool GetMove(){
		return _move;
	}

	public void SetMove(bool value){
		_move = value;
	}
	#endregion
}

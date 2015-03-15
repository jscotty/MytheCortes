using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 12f;

	public float x,y;
	private bool _attack, _move;

	public Transform sword;
	public CharacterData playerData;

	/// <summary>
	/// The character sprites.
	/// 0 = is down
	/// 1 = up
	/// 2 = left and right
	/// </summary>
	public GameObject[] characterFiew;
	public GameObject[] malincheFiew;

	Rigidbody2D _body;
	
	Joystick _joystick;

	[SerializeField]
	GameObject[] _mapSpots;
	
	enum Direction { North, South, West, East, Idle};

	void Start(){
		CharacterUp ();
		_move = true;
		_body = gameObject.GetComponent<Rigidbody2D>();

		GameObject joystickController = GameObject.FindGameObjectWithTag (Tags.JOYSTICK_CONTROLLER);
		if(joystickController != null)
			_joystick = joystickController.GetComponent<Joystick> ();

		PosPlayer ();
	}

	public void PosPlayer(){

		int mapIndex = QuestData.levelSpot;
		this.gameObject.transform.position = _mapSpots [mapIndex].transform.position;
	}

	void FixedUpdate () {
		if (_move) {
			MovePlayer();
			if (x > 0f && y == 0f) { // right
				Rotate(Direction.East);
			} else if (x < 0f && y == 0f) { // left
				Rotate(Direction.West);
			} else if (x == 0f && y > 0f) { // up
				Rotate(Direction.North);
			} else if (x == 0f && y < 0f) { // down
				Rotate(Direction.South);
			}
		} else {
			_body.velocity = new Vector2(0f,0f);
			_joystick.xAxis = 0f;
			_joystick.yAxis = 0f;
		}
	}

	/// <summary>
	/// Moves the player.
	/// </summary>
	private void MovePlayer(){
		if (_joystick != null) {
			x = _joystick.xAxis;
			y = _joystick.yAxis;
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
	void Rotate(Direction dir){
		//rotating player:
		if (dir == Direction.East) { // right
			sword.transform.eulerAngles = new Vector3(0f, 0f, 270f);
			CharacterSide();
		} else if (dir == Direction.West) { // left
			sword.transform.eulerAngles = new Vector3(0f, 0f, 90f);
			CharacterSide2();
		} else if (dir == Direction.North) { // up
			sword.transform.eulerAngles = new Vector3(0f, 0f, 0f);
			CharacterUp();
		} else if (dir == Direction.South) { // down
			sword.transform.eulerAngles = new Vector3(0f, 0f, 180f);
			CharacterDown();
		}

	}

	void CharacterUp(){
		characterFiew [0].SetActive (true);
		characterFiew [1].SetActive (false);
		characterFiew [2].SetActive (false);
		characterFiew [3].SetActive (false);
			
			malincheFiew [0].SetActive (true);
			malincheFiew [1].SetActive (false);
			malincheFiew [2].SetActive (false);
			malincheFiew [3].SetActive (false);
	}
	void CharacterSide(){
		characterFiew [0].SetActive (false);
		characterFiew [1].SetActive (false);
		characterFiew [2].SetActive (true);
		characterFiew [3].SetActive (false);

			malincheFiew [0].SetActive (false);
			malincheFiew [1].SetActive (false);
			malincheFiew [2].SetActive (true);
			malincheFiew [3].SetActive (false);
	}
	void CharacterSide2(){
		characterFiew [0].SetActive (false);
		characterFiew [1].SetActive (false);
		characterFiew [2].SetActive (false);
		characterFiew [3].SetActive (true);
		
			malincheFiew [0].SetActive (false);
			malincheFiew [1].SetActive (false);
			malincheFiew [2].SetActive (false);
			malincheFiew [3].SetActive (true);
	}
	void CharacterDown(){
		characterFiew [0].SetActive (false);
		characterFiew [1].SetActive (true);
		characterFiew [2].SetActive (false);
		characterFiew [3].SetActive (false);
			
			malincheFiew [0].SetActive (false);
			malincheFiew [1].SetActive (true);
			malincheFiew [2].SetActive (false);
			malincheFiew [3].SetActive (false);
	}

	#region getters and setters
	public bool attack{
		get {
			return _attack;
		}
		set {
			_attack = value;
		}
	} 
	
	public bool move{
		get {
			return _move;
		}
		set {
			_move = value;
		}
	} 
	#endregion
}

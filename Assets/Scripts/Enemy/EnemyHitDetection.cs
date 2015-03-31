using UnityEngine;
using System.Collections;

public class EnemyHitDetection : MonoBehaviour {

	public BoxCollider2D _feetCollider;
	public EnemyData _enemyData;
	public PlayerController playerController;

	private Joystick joystick;
	private BoxCollider2D _collider;
	private bool _attack;

	void Start(){
		_collider = gameObject.GetComponent<BoxCollider2D> ();

		GameObject stick = GameObject.FindGameObjectWithTag (Tags.JOYSTICK_CONTROLLER);
		joystick = stick.GetComponent<Joystick> ();
	}

	void Update(){
		_attack = playerController.attack;
	}

	void OnTriggerStay2D(Collider2D other){
	//	print (other.tag + " | name: " + other.name + " | attack: " + playerController.attack);
		if (other.tag == Tags.SWORD) {
			_enemyData.hit = true;
		} else if (other.tag == Tags.ATTACK && _attack) {
			_enemyData.hit = true;
		} else if (other.tag == Tags.PLAYER && _attack) {
			_enemyData.hit = true;
		} else if (other.tag == Tags.ATTACK && _attack) {
			_enemyData.hit = true;
		}
		if (other.tag == Tags.PLAYER || other.tag == Tags.ENEMY) {
			_feetCollider.isTrigger = true;	
			_collider.isTrigger = true;	
		}
	}

	void OnTriggerExit2D (Collider2D other){
		if (other.tag == Tags.PLAYER || other.tag == Tags.ENEMY) {
			_feetCollider.isTrigger = false;	
			_collider.isTrigger = false;	
		}
		_enemyData.hit = false;
	}
}

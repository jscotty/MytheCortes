using UnityEngine;
using System.Collections;

public class EnemyHitDetection : MonoBehaviour {

	public BoxCollider2D _feetCollider;
	public EnemyData _enemyData;
	public PlayerController playerController;

	private BoxCollider2D _collider;

	void Start(){
		_collider = gameObject.GetComponent<BoxCollider2D> ();
	}

	void Update(){

	}

	void OnTriggerStay2D(Collider2D other){
		if (other.tag == Tags.SWORD) {
			_enemyData.hit = true;
		} else if (other.tag == Tags.ATTACK && playerController.attack) {
			_enemyData.hit = true;
		} else if (other.tag == Tags.PLAYER && playerController.attack) {
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

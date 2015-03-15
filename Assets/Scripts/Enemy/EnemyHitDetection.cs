using UnityEngine;
using System.Collections;

public class EnemyHitDetection : MonoBehaviour {

	public AudioClip audioClip;
	public BoxCollider2D _feetCollider;
	public EnemyData _enemyData;

	private BoxCollider2D _collider;
	private AudioSource _audio;

	void Start(){
		_audio = gameObject.GetComponent<AudioSource> ();
		_collider = gameObject.GetComponent<BoxCollider2D> ();
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.tag == Tags.PLAYER || other.tag == Tags.ENEMY) {
			_feetCollider.isTrigger = true;	
			_collider.isTrigger = true;	
		} if (other.tag == Tags.SWORD) {
			_enemyData.hit = true;
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

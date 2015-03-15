using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class HitDetection : MonoBehaviour {

	GameObject _attackItem;
	bool _attack;

	DummyBehaviour _dummy;

	PlayerController _playerController;
	GameObject _player;

	private bool _hit;

	void Start(){
		_player = GameObject.FindGameObjectWithTag (Tags.PLAYER);
		_attackItem = GameObject.FindGameObjectWithTag (Tags.ATTACK);
		_dummy = gameObject.GetComponent<DummyBehaviour> ();

		_playerController = _player.GetComponent<PlayerController> ();
	}

	void Update(){
		_attack = _playerController.attack;
		if (_hit) {
			_dummy.SetDamaging(true);
		} else {
			_dummy.SetDamaging(false);

		}

	}

	void OnTriggerStay2D(Collider2D other){
		if(other.tag == Tags.SWORD){
			//print("hit");
			_attackItem = other.gameObject;
			_hit = true;
		}
		//print ("hit: " + _hit);
	}
	
	void OnTriggerExit2D(Collider2D other){
		_hit = false;
		//print ("hit: " + _hit);
	}
}
